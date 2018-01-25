using System;
using CoreBluetooth;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using WebKit;
using NearIT;

namespace NearUI
{
    // @interface NITBaseViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface NITBaseViewController
    {
        // @property (nonatomic) BOOL isEnableTapToClose;
        [Export("isEnableTapToClose")]
        bool IsEnableTapToClose { get; set; }

        // -(void)viewDidLoad;
        [Export("viewDidLoad")]
        void ViewDidLoad();

        // -(void)didReceiveMemoryWarning;
        [Export("didReceiveMemoryWarning")]
        void DidReceiveMemoryWarning();

        // -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
        [Export("initWithNibName:bundle:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

    }

    // @interface NITContentViewController : NITBaseViewController
    [BaseType(typeof(NITBaseViewController))]
    interface NITContentViewController
    {
        // @property (copy, nonatomic) WKNavigationActionPolicy (^ _Nullable)(NITContentViewController * _Nonnull, NSURLRequest * _Nonnull) linkHandler;
        [NullAllowed, Export("linkHandler", ArgumentSemantic.Copy)]
        Func<NITContentViewController, Foundation.NSUrlRequest, WKNavigationActionPolicy> LinkHandler { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(NITContentViewController * _Nonnull, NSURL * _Nonnull) callToActionHandler;
        [NullAllowed, Export("callToActionHandler", ArgumentSemantic.Copy)]
        Action<NITContentViewController, Foundation.NSUrl> CallToActionHandler { get; set; }

        // @property (nonatomic) BOOL drawSeparator;
        [Export("drawSeparator")]
        bool DrawSeparator { get; set; }

        // @property (nonatomic) BOOL hideCloseButton;
        [Export("hideCloseButton")]
        bool HideCloseButton { get; set; }

        // @property (nonatomic, strong) UIImage * _Null_unspecified imagePlaceholder;
        [Export("imagePlaceholder", ArgumentSemantic.Strong)]
        UIImage ImagePlaceholder { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull titleFont;
        [Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull titleColor;
        [Export("titleColor", ArgumentSemantic.Strong)]
        UIColor TitleColor { get; set; }

        // @property (nonatomic, strong) UIImage * _Null_unspecified callToActionButton;
        [Export("callToActionButton", ArgumentSemantic.Strong)]
        UIImage CallToActionButton { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull contentMainFont;
        [Export("contentMainFont", ArgumentSemantic.Strong)]
        UIFont ContentMainFont { get; set; }

        // -(instancetype _Nonnull)initWithContent:(NITContent * _Nonnull)content;
        [Export("initWithContent:")]
        IntPtr Constructor(NITContent content);

        [Export("initWithContent:manager:")]
        IntPtr Constructor(NITContent content, NITManager manager);

        // -(void)show;
        [Export("show")]
        void Show();

        // -(void)showFromViewController:(UIViewController * _Nullable)fromViewController configureDialog:(void (^ _Nullable)(NITDialogController * _Nonnull))configureDialog;
        [Export("showFromViewController:configureDialog:")]
        void ShowFromViewController([NullAllowed] UIViewController fromViewController, [NullAllowed] Action<NITDialogController> configureDialog);

        // -(void)showWithNavigationController:(UINavigationController * _Nonnull)navigationController;
        [Export("showWithNavigationController:")]
        void ShowWithNavigationController(UINavigationController navigationController);

        // -(void)viewDidLoad;
        [Export("viewDidLoad")]
        void ViewDidLoad();
    }

    // @interface NITCouponListViewController : NITBaseViewController <UITableViewDataSource, UITableViewDelegate>
    [BaseType(typeof(NITBaseViewController))]
    interface NITCouponListViewController : IUITableViewDataSource, IUITableViewDelegate
    {
        // @property (nonatomic) enum NITCouponListViewControllerPresentCoupon presentCoupon;
        [Export("presentCoupon", ArgumentSemantic.Assign)]
        NITCouponListViewControllerPresentCoupon PresentCoupon { get; set; }

        // @property (nonatomic) enum NITCouponListViewControllerFilterOptions filterOption;
        [Export("filterOption", ArgumentSemantic.Assign)]
        NITCouponListViewControllerFilterOptions FilterOption { get; set; }

        // @property (nonatomic) enum NITCouponListViewControllerFilterRedeemed filterRedeemed;
        [Export("filterRedeemed", ArgumentSemantic.Assign)]
        NITCouponListViewControllerFilterRedeemed FilterRedeemed { get; set; }

        // @property (nonatomic, strong) UIImage * _Null_unspecified iconPlaceholder;
        [Export("iconPlaceholder", ArgumentSemantic.Strong)]
        UIImage IconPlaceholder { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull expiredColor;
        [Export("expiredColor", ArgumentSemantic.Strong)]
        UIColor ExpiredColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull expiredFont;
        [Export("expiredFont", ArgumentSemantic.Strong)]
        UIFont ExpiredFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull disabledColor;
        [Export("disabledColor", ArgumentSemantic.Strong)]
        UIColor DisabledColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull disabledFont;
        [Export("disabledFont", ArgumentSemantic.Strong)]
        UIFont DisabledFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull validColor;
        [Export("validColor", ArgumentSemantic.Strong)]
        UIColor ValidColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull validFont;
        [Export("validFont", ArgumentSemantic.Strong)]
        UIFont ValidFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull titleFont;
        [Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull titleColor;
        [Export("titleColor", ArgumentSemantic.Strong)]
        UIColor TitleColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull titleDisabledFont;
        [Export("titleDisabledFont", ArgumentSemantic.Strong)]
        UIFont TitleDisabledFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull titleDisabledColor;
        [Export("titleDisabledColor", ArgumentSemantic.Strong)]
        UIColor TitleDisabledColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull titleExpiredFont;
        [Export("titleExpiredFont", ArgumentSemantic.Strong)]
        UIFont TitleExpiredFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull titleExpiredColor;
        [Export("titleExpiredColor", ArgumentSemantic.Strong)]
        UIColor TitleExpiredColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull valueFont;
        [Export("valueFont", ArgumentSemantic.Strong)]
        UIFont ValueFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull valueColor;
        [Export("valueColor", ArgumentSemantic.Strong)]
        UIColor ValueColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull valueDisabledFont;
        [Export("valueDisabledFont", ArgumentSemantic.Strong)]
        UIFont ValueDisabledFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull valueDisabledColor;
        [Export("valueDisabledColor", ArgumentSemantic.Strong)]
        UIColor ValueDisabledColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull valueExpiredFont;
        [Export("valueExpiredFont", ArgumentSemantic.Strong)]
        UIFont ValueExpiredFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull valueExpiredColor;
        [Export("valueExpiredColor", ArgumentSemantic.Strong)]
        UIColor ValueExpiredColor { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified expiredText;
        [Export("expiredText")]
        string ExpiredText { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified disabledText;
        [Export("disabledText")]
        string DisabledText { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified validText;
        [Export("validText")]
        string ValidText { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified noCoupons;
        [Export("noCoupons")]
        string NoCoupons { get; set; }

        // @property (nonatomic, strong) UIImage * _Null_unspecified cellBackground;
        [Export("cellBackground", ArgumentSemantic.Strong)]
        UIImage CellBackground { get; set; }

        // @property (nonatomic, strong) UIImage * _Null_unspecified selectedCellBackground;
        [Export("selectedCellBackground", ArgumentSemantic.Strong)]
        UIImage SelectedCellBackground { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(NITCouponViewController * _Nonnull) couponViewControllerConfiguration;
        [NullAllowed, Export("couponViewControllerConfiguration", ArgumentSemantic.Copy)]
        Action<NITCouponViewController> CouponViewControllerConfiguration { get; set; }

        // -(void)show;
        [Export("show")]
        void Show();

        // -(void)showFromViewController:(UIViewController * _Nullable)fromViewController;
        [Export("showFromViewController:")]
        void ShowFromViewController([NullAllowed] UIViewController fromViewController);

        // -(void)showWithNavigationController:(UINavigationController * _Nonnull)navigationController;
        [Export("showWithNavigationController:")]
        void ShowWithNavigationController(UINavigationController navigationController);

        /*// -(NSInteger)tableView:(UITableView * _Nonnull)tableView numberOfRowsInSection:(NSInteger)section __attribute__((warn_unused_result));
        [Export("tableView:numberOfRowsInSection:")]
        nint TableView(UITableView tableView, nint section);

        // -(NSInteger)numberOfSectionsInTableView:(UITableView * _Nonnull)tableView __attribute__((warn_unused_result));
        [Export("numberOfSectionsInTableView:")]
        nint NumberOfSectionsInTableView(UITableView tableView);

        // -(UIView * _Nullable)tableView:(UITableView * _Nonnull)tableView viewForHeaderInSection:(NSInteger)section __attribute__((warn_unused_result));
        [Export("tableView:viewForHeaderInSection:")]
        [return: NullAllowed]
        UIView TableView(UITableView tableView, nint section);

        // -(UITableViewCell * _Nonnull)tableView:(UITableView * _Nonnull)tableView cellForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
        [Export("tableView:cellForRowAtIndexPath:")]
        UITableViewCell TableView(UITableView tableView, NSIndexPath indexPath);

        // -(void)tableView:(UITableView * _Nonnull)tableView didSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableView:didSelectRowAtIndexPath:")]
        void TableView(UITableView tableView, NSIndexPath indexPath);*/
    }

    // @interface NITCouponViewController : NITBaseViewController
    [BaseType(typeof(NITBaseViewController))]
    interface NITCouponViewController
    {
        // @property (nonatomic) BOOL drawSeparator;
        [Export("drawSeparator")]
        bool DrawSeparator { get; set; }

        // @property (nonatomic) BOOL hideCloseButton;
        [Export("hideCloseButton")]
        bool HideCloseButton { get; set; }

        // @property (nonatomic, strong) UIImage * _Null_unspecified separatorImage;
        [Export("separatorImage", ArgumentSemantic.Strong)]
        UIImage SeparatorImage { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull separatorBackgroundColor;
        [Export("separatorBackgroundColor", ArgumentSemantic.Strong)]
        UIColor SeparatorBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIImage * _Null_unspecified iconPlaceholder;
        [Export("iconPlaceholder", ArgumentSemantic.Strong)]
        UIImage IconPlaceholder { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified expiredText;
        [Export("expiredText")]
        string ExpiredText { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified disabledText;
        [Export("disabledText")]
        string DisabledText { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified validText;
        [Export("validText")]
        string ValidText { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified fromText;
        [Export("fromText")]
        string FromText { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified toText;
        [Export("toText")]
        string ToText { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull couponValidColor;
        [Export("couponValidColor", ArgumentSemantic.Strong)]
        UIColor CouponValidColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull couponDisabledColor;
        [Export("couponDisabledColor", ArgumentSemantic.Strong)]
        UIColor CouponDisabledColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull couponExpiredColor;
        [Export("couponExpiredColor", ArgumentSemantic.Strong)]
        UIColor CouponExpiredColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull validFont;
        [Export("validFont", ArgumentSemantic.Strong)]
        UIFont ValidFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull fromToFont;
        [Export("fromToFont", ArgumentSemantic.Strong)]
        UIFont FromToFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull alternativeFont;
        [Export("alternativeFont", ArgumentSemantic.Strong)]
        UIFont AlternativeFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull titleFont;
        [Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull titleColor;
        [Export("titleColor", ArgumentSemantic.Strong)]
        UIColor TitleColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull descriptionFont;
        [Export("descriptionFont", ArgumentSemantic.Strong)]
        UIFont DescriptionFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull descriptionColor;
        [Export("descriptionColor", ArgumentSemantic.Strong)]
        UIColor DescriptionColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull serialFont;
        [Export("serialFont", ArgumentSemantic.Strong)]
        UIFont SerialFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull serialColor;
        [Export("serialColor", ArgumentSemantic.Strong)]
        UIColor SerialColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull valueFont;
        [Export("valueFont", ArgumentSemantic.Strong)]
        UIFont ValueFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull valueColor;
        [Export("valueColor", ArgumentSemantic.Strong)]
        UIColor ValueColor { get; set; }

        // -(instancetype _Nonnull)initWithCoupon:(id)coupon;
        [Export("initWithCoupon:")]
        IntPtr Constructor(NITCoupon coupon);

        [Export("initWithCoupon:manager:")]
        IntPtr Constructor(NITCoupon coupon, NITManager manager);

        // -(void)show;
        [Export("show")]
        void Show();

        // -(void)showFromViewController:(UIViewController * _Nullable)fromViewController configureDialog:(void (^ _Nullable)(NITDialogController * _Nonnull))configureDialog;
        [Export("showFromViewController:configureDialog:")]
        void ShowFromViewController([NullAllowed] UIViewController fromViewController, [NullAllowed] Action<NITDialogController> configureDialog);

        // -(void)showWithNavigationController:(UINavigationController * _Nonnull)navigationController;
        [Export("showWithNavigationController:")]
        void ShowWithNavigationController(UINavigationController navigationController);
    }

    // @interface NITDialogController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface NITDialogController
    {
        // @property (nonatomic) enum CFAlertControllerBackgroundStyle backgroundStyle;
        [Export("backgroundStyle", ArgumentSemantic.Assign)]
        CFAlertControllerBackgroundStyle BackgroundStyle { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
        [NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic) enum CFAlertControllerContentPosition contentPosition;
        [Export("contentPosition", ArgumentSemantic.Assign)]
        CFAlertControllerContentPosition ContentPosition { get; set; }

        // -(void)observeValueForKeyPath:(NSString * _Nullable)keyPath ofObject:(id _Nullable)object change:(NSDictionary<NSKeyValueChangeKey,id> * _Nullable)change context:(void * _Nullable)context;
        [Export("observeValueForKeyPath:ofObject:change:context:")]
        void ObserveValueForKeyPath([NullAllowed] string keyPath, [NullAllowed] NSObject @object, [NullAllowed] NSDictionary<NSString, NSObject> change, [NullAllowed] NSObject context);

        // -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
        [Export("initWithNibName:bundle:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);
    }

    /*
    // @interface NearUIBinding_Swift_383 (NITDialogController) <UIGestureRecognizerDelegate>
    [Category]
    [BaseType(typeof(NITDialogController))]
    interface NITDialogController_NearUIBinding_Swift_383 : IUIGestureRecognizerDelegate
    {
        // -(BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldReceiveTouch:(UITouch * _Nonnull)touch __attribute__((warn_unused_result));
        [Export("gestureRecognizer:shouldReceiveTouch:")]
        bool GestureRecognizer(UIGestureRecognizer gestureRecognizer, UITouch touch);
    }*/

    //delegate void FeedbackCallback(NITFeedbackViewController FeedbackViewController, int Integer, NSString String, Action<bool> Boolean);

    // @interface NITFeedbackViewController : NITBaseViewController
    [BaseType(typeof(NITBaseViewController))]
    interface NITFeedbackViewController
    {
        // @property (copy, nonatomic) void (^ _Nullable)(NITFeedbackViewController * _Nonnull, NSInteger, NSString * _Nullable, void (^ _Nonnull)(BOOL)) feedbackSendCallback;
        /*[NullAllowed, Export("feedbackSendCallback", ArgumentSemantic.Copy)]
        Action<FeedbackCallback> FeedbackSendCallback { get; set; }*/

        // @property (nonatomic, strong) UIImage * _Null_unspecified sendButton;
        [Export("sendButton", ArgumentSemantic.Strong)]
        UIImage SendButton { get; set; }

        // @property (nonatomic, strong) UIImage * _Null_unspecified rateFullButton;
        [Export("rateFullButton", ArgumentSemantic.Strong)]
        UIImage RateFullButton { get; set; }

        // @property (nonatomic, strong) UIImage * _Null_unspecified rateEmptyButton;
        [Export("rateEmptyButton", ArgumentSemantic.Strong)]
        UIImage RateEmptyButton { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull textColor;
        [Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable textFont;
        [NullAllowed, Export("textFont", ArgumentSemantic.Strong)]
        UIFont TextFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull errorColor;
        [Export("errorColor", ArgumentSemantic.Strong)]
        UIColor ErrorColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable errorFont;
        [NullAllowed, Export("errorFont", ArgumentSemantic.Strong)]
        UIFont ErrorFont { get; set; }

        // @property (nonatomic, strong) UIImage * _Null_unspecified retryButton;
        [Export("retryButton", ArgumentSemantic.Strong)]
        UIImage RetryButton { get; set; }

        // @property (nonatomic) enum NITFeedbackCommentVisibility commentVisibility;
        [Export("commentVisibility", ArgumentSemantic.Assign)]
        NITFeedbackCommentVisibility CommentVisibility { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified closeText;
        [Export("closeText")]
        string CloseText { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified commentDescriptionText;
        [Export("commentDescriptionText")]
        string CommentDescriptionText { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified sendText;
        [Export("sendText")]
        string SendText { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified errorText;
        [Export("errorText")]
        string ErrorText { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified retryText;
        [Export("retryText")]
        string RetryText { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified okText;
        [Export("okText")]
        string OkText { get; set; }

        // @property (nonatomic) double disappearTime;
        [Export("disappearTime")]
        double DisappearTime { get; set; }

        // -(instancetype _Nonnull)initWithFeedback:(NITFeedback * _Nonnull)feedback;
        [Export("initWithFeedback:")]
        IntPtr Constructor(NITFeedback feedback);

        // -(instancetype _Nonnull)initWithFeedback:(NITFeedback * _Nonnull)feedback feedbackSendCallback:(void (^ _Nullable)(NITFeedbackViewController * _Nonnull, NSInteger, NSString * _Nullable, void (^ _Nonnull)(BOOL)))feedbackSendCallback;
        /*[Export("initWithFeedback:feedbackSendCallback:manager:")]
        IntPtr Constructor(NITFeedback feedback, [NullAllowed] Action<FeedbackCallback> feedbackSendCallback, NITManager manager);*/

        // -(void)show;
        [Export("show")]
        void Show();

        // -(void)showFromViewController:(UIViewController * _Nullable)fromViewController configureDialog:(void (^ _Nullable)(NITDialogController * _Nonnull))configureDialog;
        [Export("showFromViewController:configureDialog:")]
        void ShowFromViewController([NullAllowed] UIViewController fromViewController, [NullAllowed] Action<NITDialogController> configureDialog);
    }

    // @protocol NITPermissionsViewControllerDelegate
    [Protocol, Model]
    interface NITPermissionsViewControllerDelegate
    {
        // @optional -(void)locationGranted:(BOOL)granted;
        [Export("locationGranted:")]
        void LocationGranted(bool granted);

        // @optional -(void)notificationsGranted:(BOOL)granted;
        [Export("notificationsGranted:")]
        void NotificationsGranted(bool granted);

        // @optional -(void)dialogClosedWithLocationGranted:(BOOL)locationGranted notificationsGranted:(BOOL)notificationsGranted;
        [Export("dialogClosedWithLocationGranted:notificationsGranted:")]
        void DialogClosedWithLocationGranted(bool locationGranted, bool notificationsGranted);
    }

    /*
    // @interface NITPermissionsView : UIView <CBPeripheralManagerDelegate, NITPermissionsViewControllerDelegate>
    [BaseType(typeof(UIView))]
    interface NITPermissionsView : ICBPeripheralManagerDelegate, NITPermissionsViewControllerDelegate, NITPermissionsManagerDelegate
    {
        // @property (copy, nonatomic) NSString * _Nullable messageText;
        [NullAllowed, Export("messageText")]
        string MessageText { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable messageColor;
        [NullAllowed, Export("messageColor", ArgumentSemantic.Strong)]
        UIColor MessageColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable messageFont;
        [NullAllowed, Export("messageFont", ArgumentSemantic.Strong)]
        UIFont MessageFont { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable buttonText;
        [NullAllowed, Export("buttonText")]
        string ButtonText { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable buttonColor;
        [NullAllowed, Export("buttonColor", ArgumentSemantic.Strong)]
        UIColor ButtonColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable buttonFont;
        [NullAllowed, Export("buttonFont", ArgumentSemantic.Strong)]
        UIFont ButtonFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable permissionAvailableColor;
        [NullAllowed, Export("permissionAvailableColor", ArgumentSemantic.Strong)]
        UIColor PermissionAvailableColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable permissionNotAvailableColor;
        [NullAllowed, Export("permissionNotAvailableColor", ArgumentSemantic.Strong)]
        UIColor PermissionNotAvailableColor { get; set; }

        // @property (nonatomic) BOOL animateView;
        [Export("animateView")]
        bool AnimateView { get; set; }

        // @property (nonatomic) enum NITPermissionsViewPermissions permissionsRequired;
        [Export("permissionsRequired", ArgumentSemantic.Assign)]
        NITPermissionsViewPermissions PermissionsRequired { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(NITPermissionsView * _Nonnull) callbackOnPermissions;
        [NullAllowed, Export("callbackOnPermissions", ArgumentSemantic.Copy)]
        Action<NITPermissionsView> CallbackOnPermissions { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable buttonBackgroundImage;
        [NullAllowed, Export("buttonBackgroundImage", ArgumentSemantic.Strong)]
        UIImage ButtonBackgroundImage { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(void)peripheralManagerDidUpdateState:(CBPeripheralManager * _Nonnull)peripheral;
        [Export("peripheralManagerDidUpdateState:")]
        void PeripheralManagerDidUpdateState(CBPeripheralManager peripheral);

        // -(void)notificationsGranted:(BOOL)granted;
        [Export("notificationsGranted:")]
        void NotificationsGranted(bool granted);
    }
    */

    // @interface NITPermissionsViewController : NITBaseViewController
    [BaseType(typeof(NITBaseViewController))]
    interface NITPermissionsViewController
    {
        // @property (nonatomic) enum NITPermissionsType type;
        [Export("type", ArgumentSemantic.Assign)]
        NITPermissionsType Type { get; set; }

        // @property (nonatomic) enum NITPermissionsLocationType locationType;
        [Export("locationType", ArgumentSemantic.Assign)]
        NITPermissionsLocationType LocationType { get; set; }

        // @property (nonatomic) enum NITPermissionsAutoStartRadarType autoStartRadar;
        [Export("autoStartRadar", ArgumentSemantic.Assign)]
        NITPermissionsAutoStartRadarType AutoStartRadar { get; set; }

        // @property (nonatomic) enum NITPermissionsAutoCloseDialog autoCloseDialog;
        [Export("autoCloseDialog", ArgumentSemantic.Assign)]
        NITPermissionsAutoCloseDialog AutoCloseDialog { get; set; }

        // @property (nonatomic, strong) UIImage * _Null_unspecified unknownButton;
        [Export("unknownButton", ArgumentSemantic.Strong)]
        UIImage UnknownButton { get; set; }

        // @property (nonatomic, strong) UIImage * _Null_unspecified grantedButton;
        [Export("grantedButton", ArgumentSemantic.Strong)]
        UIImage GrantedButton { get; set; }

        // @property (nonatomic, strong) UIImage * _Null_unspecified grantedIcon;
        [Export("grantedIcon", ArgumentSemantic.Strong)]
        UIImage GrantedIcon { get; set; }

        // @property (nonatomic, strong) UIImage * _Null_unspecified headerImage;
        [Export("headerImage", ArgumentSemantic.Strong)]
        UIImage HeaderImage { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified textColor;
        [Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified locationText;
        [Export("locationText")]
        string LocationText { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified notificationsText;
        [Export("notificationsText")]
        string NotificationsText { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified explainText;
        [Export("explainText")]
        string ExplainText { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified closeText;
        [Export("closeText")]
        string CloseText { get; set; }

        // @property (copy, nonatomic) NSString * _Null_unspecified notNowText;
        [Export("notNowText")]
        string NotNowText { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        NITPermissionsViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<NITPermissionsViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(BOOL)checkPermissions __attribute__((warn_unused_result));
        [Export("checkPermissions")]
        bool CheckPermissions { get; }

        // -(instancetype _Nonnull)initWithLocationType:(enum NITPermissionsLocationType)locationType;
        [Export("initWithLocationType:")]
        IntPtr Constructor(NITPermissionsLocationType locationType);

        // -(instancetype _Nonnull)initWithType:(enum NITPermissionsType)type;
        [Export("initWithType:")]
        IntPtr Constructor(NITPermissionsType type);

        // -(instancetype _Nonnull)initWithType:(enum NITPermissionsType)type locationType:(enum NITPermissionsLocationType)locationType autoStartRadar:(enum NITPermissionsAutoStartRadarType)autoStartRadar autoCloseDialog:(enum NITPermissionsAutoCloseDialog)autoCloseDialog __attribute__((objc_designated_initializer));
        [Export("initWithType:locationType:autoStartRadar:autoCloseDialog:")]
        [DesignatedInitializer]
        IntPtr Constructor(NITPermissionsType type, NITPermissionsLocationType locationType, NITPermissionsAutoStartRadarType autoStartRadar, NITPermissionsAutoCloseDialog autoCloseDialog);

        // -(void)show;
        [Export("show")]
        void Show();

        // -(void)showWithConfigureDialog:(void (^ _Nullable)(NITDialogController * _Nonnull))configureDialog;
        [Export("showWithConfigureDialog:")]
        void ShowWithConfigureDialog([NullAllowed] Action<NITDialogController> configureDialog);

        // -(void)showFromViewController:(UIViewController * _Nonnull)fromViewController configureDialog:(void (^ _Nullable)(NITDialogController * _Nonnull))configureDialog;
        [Export("showFromViewController:configureDialog:")]
        void ShowFromViewController(UIViewController fromViewController, [NullAllowed] Action<NITDialogController> configureDialog);
    }
}