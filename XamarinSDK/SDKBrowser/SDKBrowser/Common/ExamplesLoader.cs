using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Xamarin.Forms;

namespace SDKBrowser.Common
{
    public class ExamplesLoader
    {
        private static string deviceOSName;

        private List<XFControl> controls;

        public ExamplesLoader(string sourceFile)
        {
            this.ReadXmlFile(sourceFile);
        }

        private static string DeviceOSName
        {
            get
            {
                if (deviceOSName == null)
                {
                    deviceOSName = DependencyService.Get<IDevice>().Device.ToString();
                }

                return deviceOSName;
            }
        }

        private void ReadXmlFile(string sourceFile)
        {
            var assembly = typeof(ExamplesLoader).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(sourceFile);

            using (var reader = new System.IO.StreamReader(stream))
            {
                var serializer = new XmlSerializer(typeof(List<XFControl>));
                this.controls = (List<XFControl>)serializer.Deserialize(reader);
            }
        }

        internal IEnumerable<string> GetAvailableControls()
        {
            List<string> controlsWithExamples = new List<string>();
            foreach (XFControl control in this.controls)
            {
                if (this.ShouldExcludeItemForCurrentDevice(control.ExcludeFrom))
                {
                    continue;
                }
                else
                {
                    controlsWithExamples.Add(control.Name);
                }
            }
            return controlsWithExamples;
        }

        private IEnumerable<string> NormalizeExcludeFlags(string excludeFlags)
        {
            if (excludeFlags.Contains(","))
            {
                List<string> flags = excludeFlags.Split(',').ToList<string>();
                return flags;
            }
            return new List<string>() { excludeFlags };
        }

        internal IEnumerable<Example> GetFlatExamples (string controlName)
        {
            var examples = new List<Example>();
            foreach (XFControl control in this.controls)
            {
                if (control.Name.Equals(controlName))
                {
                    foreach (Example example in control.Examples)
                    {
                        examples.Add(example );
                    }
                }
            }
            return examples;
        }

        internal IEnumerable<ExampleGroup> GetExamplesGroups(string controlName)
        {
            var groups = new Dictionary<string, ExampleGroup>();
            foreach (XFControl control in this.controls)
            {
                if (control.Name.Equals(controlName))
                {
                    ExampleGroup group;

                    foreach (Example example in control.Examples)
                    {
                        if (string.IsNullOrEmpty(example.GroupName) || this.ShouldExcludeItemForCurrentDevice(example.ExcludeFrom))
                        {
                            continue;
                        }

                        if (!groups.TryGetValue(example.GroupName, out group))
                        {
                            group = new ExampleGroup();
                            group.Name = example.GroupName;
                            groups.Add(example.GroupName, group);
                        }

                        group.Examples.Add(example);
                    }
                }
            }
            return groups.Values;
        }

        internal string GetExamplePageName(string controlName, string groupName, string exampleTitle)
        {
            foreach (XFControl control in this.controls)
            {
                if (control.Name.Equals(controlName))
                {
                    foreach (Example example in control.Examples)
                    {
                        if (example.Title.Equals(exampleTitle) &&
                            (string.IsNullOrEmpty(example.GroupName) && string.IsNullOrEmpty(groupName) || example.GroupName.Equals(groupName)))
                        {
                            if (example.PageName != null || !string.IsNullOrEmpty(example.PageName))
                            {
                                return example.PageName;
                            }
                            else
                            {
                                return example.Title;
                            }
                        }
                        continue;
                    }
                }
                continue;
            }
            throw new ArgumentException("Could not find PageName for {0} example.", exampleTitle);
        }

        private bool ShouldExcludeItemForCurrentDevice(string excludeFrom)
        {
            bool shouldExcludeItem = false;

            if (!string.IsNullOrEmpty(excludeFrom))
            {
                var excludeFlags = this.NormalizeExcludeFlags(excludeFrom);
                shouldExcludeItem = excludeFlags.Contains(DeviceOSName);
            }

            return shouldExcludeItem;
        }
    }
}
