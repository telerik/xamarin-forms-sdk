using System;
using System.Collections.Generic;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using Com.Telerik.Widget.Dataform.Engine;
using Com.Telerik.Widget.Dataform.Visualization;
using Com.Telerik.Widget.Dataform.Visualization.Core;
using SDKBrowser.Examples.DataFormControl.EditorsCategory.CustomEditorExample;

namespace SDKBrowser.Droid.Examples.DataFormControl.EditorsCategory.CustomEditorExample
{
    public class PopupEditor : EntityPropertyEditor, View.IOnClickListener, IPropertyChangedListener
    {
        private Java.Lang.Object editorValue;
        private Button editorButton;
        private FragmentManager fragmentManager;
        private PopupEditorFragment fragment;

        public PopupEditor(RadDataForm dataForm, IEntityProperty property, FragmentManager fragmentManager)
            : base(
                    dataForm,
                    dataForm.EditorsMainLayout,
                    dataForm.EditorsHeaderLayout,
                    Resource.Id.data_form_text_viewer_header,
                    Resource.Layout.dataform_popup_editor,
                    Resource.Id.popup_editor,
                    dataForm.EditorsValidationLayout,
                    property)
        {
            this.editorButton = (Button)this.EditorView;
            this.editorButton.SetOnClickListener(this);
            ((TextView) this.HeaderView).Text = property.Header;
            this.fragmentManager = fragmentManager;
            this.InitPopupFragment();
        }

        protected override void ApplyEntityValueToEditor(Java.Lang.Object o)
        {
            if (o == null)
            {
                this.editorButton.Text = "Tap to select.";
                return;
            }

            this.editorButton.Text = o.ToString();
            this.editorValue = o;
        }

        public void OnClick(View v)
        {
            this.ShowEditorFragment();
        }

        public override Java.Lang.Object Value()
        {
            return this.editorValue;
        }

        public void OnPropertyChanged(String s, Java.Lang.Object o)
        {
            if (o.ToString() == this.editorValue.ToString())
            {
                return;
            }

            ApplyEntityValueToEditor(o);

            // Remember to call value changed, otherwise the object being edited will not be updated.
            OnEditorValueChanged(o);
        }

        private void ShowEditorFragment()
        {
            this.fragment.Show(this.fragmentManager, "customEditor");
        }

        private void InitPopupFragment()
        {
            var items = new List<PopupItem>
            {
                new PopupItem
                    {
                        Title = Options.Select.ToString()
                    },
                new PopupItem
                    {
                        Title = Options.Option1.ToString()
                    },
                new PopupItem
                    {
                        Title = Options.Option2.ToString()
                    },
                new PopupItem
                    {
                        Title = Options.Option3.ToString()
                    },
                new PopupItem
                    {
                        Title = Options.Option4.ToString()
                    }
            };

            this.fragment = new PopupEditorFragment(items);
            this.fragment.AddPropertyChangedListener(this);
        }
    }
}