using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using RetriX.Shared.ViewModels;
using System;
using UIKit;

namespace RetriX.iOS
{
    [MvxFromStoryboard("AddGenerator")]
    public partial class AddGeneratorView : MvxTableViewController<AddGeneratorViewModel>
    {
        public AddGeneratorView (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var saveButton = new UIBarButtonItem(UIBarButtonSystemItem.Save);
            var cancelButton = new UIBarButtonItem(UIBarButtonSystemItem.Cancel);
            NavigationItem.RightBarButtonItem = saveButton;
            NavigationItem.BackBarButtonItem = cancelButton;

            var set = this.CreateBindingSet<AddGeneratorView, AddGeneratorViewModel>();
            set.Bind(LabelTextField).To(m => m.Label);
            set.Bind(SecretTextField).To(m => m.SecretBase32);
            set.Bind(IssuerTextField).To(m => m.Issuer);
            set.Bind(AllowExportingToggle).To(m => m.AllowExporting);
            set.Bind(saveButton).To(m => m.AddGenerator);
            set.Bind(cancelButton).To(m => m.Cancel);
            set.Apply();
        }

        public override string TitleForHeader(UITableView tableView, nint section)
        {
            switch (section)
            {
                case 0:
                    return NSBundle.MainBundle.GetLocalizedString("AddAccount", string.Empty);
                default:
                    return string.Empty;
            }
        }
    }
}