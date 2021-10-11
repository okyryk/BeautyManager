using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;


namespace BeautyManager.Views.Forms
{
    /// <summary>
    /// Page to login with user name and password
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginPage" /> class.
        /// </summary>
        public LoginPage()
        {
            this.InitializeComponent();

            PlatformConditions();
        }


        void PlatformConditions()
		{
            /*Default = LoginBackground.png,
                                                                  iOSPhoneLandscape = LoginBackground - Landscape.png,
                                                                  iOSTabletLandscape = LoginBackground - Landscape.png}"*/
            /* Syncfusion.XForms.Core.OnPlatformOrientationStringValue OnPlatformOrientationStringValue = new Syncfusion.XForms.Core.OnPlatformOrientationStringValue();
             OnPlatformOrientationStringValue.Default = "LoginBackground.png";
             OnPlatformOrientationStringValue.iOSPhoneLandscape = "LoginBackground-Landscape.png";
             OnPlatformOrientationStringValue.iOSTabletLandscape = "LoginBackground-Landscape.png";*/

           // if (Device.RuntimePlatform == Device.WPF)
            {
                /*BackgroundImageSource*/
                switch (Device.RuntimePlatform)
                {
                    case Device.iOS:
                        if (Device.Idiom == TargetIdiom.Tablet)
                        {
                            BackgroundImageSource = "LoginBackground-Landscape.png";
                        }
                        else
                        {
                            BackgroundImageSource = "LoginBackground.png";
                        }
                        break;
                    default:
                        BackgroundImageSource = "LoginBackground.png";
                        break;
                }

                /*StackLayout.Margin*/

                switch (Device.Idiom)
                {
                    case TargetIdiom.Phone:
                        if (BeautyManager.Helpers.PageHelper.IsPortrait(this))
                        {
                            SV_StackLayout.Margin = new Thickness(20, 32);
                        }
                        else
                        {
                            SV_StackLayout.Margin = new Thickness(150, 32);
                        }
                        break;
                    case TargetIdiom.Tablet:
                        if (BeautyManager.Helpers.PageHelper.IsPortrait(this))
                        {
                            SV_StackLayout.Margin = new Thickness(200, 50);
                        }
                        else
                        {
                            SV_StackLayout.Margin = new Thickness(300, 50);
                        }
                        break;
                    default:
                    case TargetIdiom.Desktop:
                        SV_StackLayout.Margin = new Thickness(30);
                        break;
                }
            }

        }
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called
            PlatformConditions();
        }
    }
}