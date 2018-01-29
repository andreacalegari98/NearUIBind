// Generated by Apple Swift version 4.0.3 (swiftlang-900.0.74.1 clang-900.0.39.2)
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wgcc-compat"

#if !defined(__has_include)
# define __has_include(x) 0
#endif
#if !defined(__has_attribute)
# define __has_attribute(x) 0
#endif
#if !defined(__has_feature)
# define __has_feature(x) 0
#endif
#if !defined(__has_warning)
# define __has_warning(x) 0
#endif

#if __has_attribute(external_source_symbol)
# define SWIFT_STRINGIFY(str) #str
# define SWIFT_MODULE_NAMESPACE_PUSH(module_name) _Pragma(SWIFT_STRINGIFY(clang attribute push(__attribute__((external_source_symbol(language="Swift", defined_in=module_name, generated_declaration))), apply_to=any(function, enum, objc_interface, objc_category, objc_protocol))))
# define SWIFT_MODULE_NAMESPACE_POP _Pragma("clang attribute pop")
#else
# define SWIFT_MODULE_NAMESPACE_PUSH(module_name)
# define SWIFT_MODULE_NAMESPACE_POP
#endif

#if __has_include(<swift/objc-prologue.h>)
# include <swift/objc-prologue.h>
#endif

#pragma clang diagnostic ignored "-Wauto-import"
#include <objc/NSObject.h>
#include <stdint.h>
#include <stddef.h>
#include <stdbool.h>

#if !defined(SWIFT_TYPEDEFS)
# define SWIFT_TYPEDEFS 1
# if __has_include(<uchar.h>)
#  include <uchar.h>
# elif !defined(__cplusplus) || __cplusplus < 201103L
typedef uint_least16_t char16_t;
typedef uint_least32_t char32_t;
# endif
typedef float swift_float2  __attribute__((__ext_vector_type__(2)));
typedef float swift_float3  __attribute__((__ext_vector_type__(3)));
typedef float swift_float4  __attribute__((__ext_vector_type__(4)));
typedef double swift_double2  __attribute__((__ext_vector_type__(2)));
typedef double swift_double3  __attribute__((__ext_vector_type__(3)));
typedef double swift_double4  __attribute__((__ext_vector_type__(4)));
typedef int swift_int2  __attribute__((__ext_vector_type__(2)));
typedef int swift_int3  __attribute__((__ext_vector_type__(3)));
typedef int swift_int4  __attribute__((__ext_vector_type__(4)));
typedef unsigned int swift_uint2  __attribute__((__ext_vector_type__(2)));
typedef unsigned int swift_uint3  __attribute__((__ext_vector_type__(3)));
typedef unsigned int swift_uint4  __attribute__((__ext_vector_type__(4)));
#endif

#if !defined(SWIFT_PASTE)
# define SWIFT_PASTE_HELPER(x, y) x##y
# define SWIFT_PASTE(x, y) SWIFT_PASTE_HELPER(x, y)
#endif
#if !defined(SWIFT_METATYPE)
# define SWIFT_METATYPE(X) Class
#endif
#if !defined(SWIFT_CLASS_PROPERTY)
# if __has_feature(objc_class_property)
#  define SWIFT_CLASS_PROPERTY(...) __VA_ARGS__
# else
#  define SWIFT_CLASS_PROPERTY(...)
# endif
#endif

#if __has_attribute(objc_runtime_name)
# define SWIFT_RUNTIME_NAME(X) __attribute__((objc_runtime_name(X)))
#else
# define SWIFT_RUNTIME_NAME(X)
#endif
#if __has_attribute(swift_name)
# define SWIFT_COMPILE_NAME(X) __attribute__((swift_name(X)))
#else
# define SWIFT_COMPILE_NAME(X)
#endif
#if __has_attribute(objc_method_family)
# define SWIFT_METHOD_FAMILY(X) __attribute__((objc_method_family(X)))
#else
# define SWIFT_METHOD_FAMILY(X)
#endif
#if __has_attribute(noescape)
# define SWIFT_NOESCAPE __attribute__((noescape))
#else
# define SWIFT_NOESCAPE
#endif
#if __has_attribute(warn_unused_result)
# define SWIFT_WARN_UNUSED_RESULT __attribute__((warn_unused_result))
#else
# define SWIFT_WARN_UNUSED_RESULT
#endif
#if __has_attribute(noreturn)
# define SWIFT_NORETURN __attribute__((noreturn))
#else
# define SWIFT_NORETURN
#endif
#if !defined(SWIFT_CLASS_EXTRA)
# define SWIFT_CLASS_EXTRA
#endif
#if !defined(SWIFT_PROTOCOL_EXTRA)
# define SWIFT_PROTOCOL_EXTRA
#endif
#if !defined(SWIFT_ENUM_EXTRA)
# define SWIFT_ENUM_EXTRA
#endif
#if !defined(SWIFT_CLASS)
# if __has_attribute(objc_subclassing_restricted)
#  define SWIFT_CLASS(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) __attribute__((objc_subclassing_restricted)) SWIFT_CLASS_EXTRA
#  define SWIFT_CLASS_NAMED(SWIFT_NAME) __attribute__((objc_subclassing_restricted)) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
# else
#  define SWIFT_CLASS(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
#  define SWIFT_CLASS_NAMED(SWIFT_NAME) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
# endif
#endif

#if !defined(SWIFT_PROTOCOL)
# define SWIFT_PROTOCOL(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) SWIFT_PROTOCOL_EXTRA
# define SWIFT_PROTOCOL_NAMED(SWIFT_NAME) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_PROTOCOL_EXTRA
#endif

#if !defined(SWIFT_EXTENSION)
# define SWIFT_EXTENSION(M) SWIFT_PASTE(M##_Swift_, __LINE__)
#endif

#if !defined(OBJC_DESIGNATED_INITIALIZER)
# if __has_attribute(objc_designated_initializer)
#  define OBJC_DESIGNATED_INITIALIZER __attribute__((objc_designated_initializer))
# else
#  define OBJC_DESIGNATED_INITIALIZER
# endif
#endif
#if !defined(SWIFT_ENUM_ATTR)
# if defined(__has_attribute) && __has_attribute(enum_extensibility)
#  define SWIFT_ENUM_ATTR __attribute__((enum_extensibility(open)))
# else
#  define SWIFT_ENUM_ATTR
# endif
#endif
#if !defined(SWIFT_ENUM)
# define SWIFT_ENUM(_type, _name) enum _name : _type _name; enum SWIFT_ENUM_ATTR SWIFT_ENUM_EXTRA _name : _type
# if __has_feature(generalized_swift_name)
#  define SWIFT_ENUM_NAMED(_type, _name, SWIFT_NAME) enum _name : _type _name SWIFT_COMPILE_NAME(SWIFT_NAME); enum SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_ENUM_ATTR SWIFT_ENUM_EXTRA _name : _type
# else
#  define SWIFT_ENUM_NAMED(_type, _name, SWIFT_NAME) SWIFT_ENUM(_type, _name)
# endif
#endif
#if !defined(SWIFT_UNAVAILABLE)
# define SWIFT_UNAVAILABLE __attribute__((unavailable))
#endif
#if !defined(SWIFT_UNAVAILABLE_MSG)
# define SWIFT_UNAVAILABLE_MSG(msg) __attribute__((unavailable(msg)))
#endif
#if !defined(SWIFT_AVAILABILITY)
# define SWIFT_AVAILABILITY(plat, ...) __attribute__((availability(plat, __VA_ARGS__)))
#endif
#if !defined(SWIFT_DEPRECATED)
# define SWIFT_DEPRECATED __attribute__((deprecated))
#endif
#if !defined(SWIFT_DEPRECATED_MSG)
# define SWIFT_DEPRECATED_MSG(...) __attribute__((deprecated(__VA_ARGS__)))
#endif
#if __has_feature(attribute_diagnose_if_objc)
# define SWIFT_DEPRECATED_OBJC(Msg) __attribute__((diagnose_if(1, Msg, "warning")))
#else
# define SWIFT_DEPRECATED_OBJC(Msg) SWIFT_DEPRECATED_MSG(Msg)
#endif
#if __has_feature(modules)
@import Foundation;
@import UIKit;
@import WebKit;
@import NearITSDK.Private;
@import CoreGraphics;
@import CoreBluetooth;
#endif

#pragma clang diagnostic ignored "-Wproperty-attribute-mismatch"
#pragma clang diagnostic ignored "-Wduplicate-method-arg"
#if __has_warning("-Wpragma-clang-attribute")
# pragma clang diagnostic ignored "-Wpragma-clang-attribute"
#endif
#pragma clang diagnostic ignored "-Wunknown-pragmas"
#pragma clang diagnostic ignored "-Wnullability"

SWIFT_MODULE_NAMESPACE_PUSH("NearUIBinding")


@class NSCoder;

SWIFT_CLASS_NAMED("NITBaseViewController")
@interface NITBaseViewController : UIViewController
@property (nonatomic) BOOL isEnableTapToClose;
- (void)viewDidLoad;
- (void)didReceiveMemoryWarning;
- (nonnull instancetype)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil OBJC_DESIGNATED_INITIALIZER;
- (nullable instancetype)initWithCoder:(NSCoder * _Nonnull)aDecoder OBJC_DESIGNATED_INITIALIZER;
@end

@class UIImage;
@class UIFont;
@class UIColor;
@class NITContent;
@class NITManager;
@class NITDialogController;
@class UINavigationController;

SWIFT_CLASS_NAMED("NITContentViewController")
@interface NITContentViewController : NITBaseViewController
@property (nonatomic, copy) WKNavigationActionPolicy (^ _Nullable linkHandler)(NITContentViewController * _Nonnull, NSURLRequest * _Nonnull);
@property (nonatomic, copy) void (^ _Nullable callToActionHandler)(NITContentViewController * _Nonnull, NSURL * _Nonnull);
@property (nonatomic) BOOL drawSeparator;
@property (nonatomic) BOOL hideCloseButton;
@property (nonatomic, strong) UIImage * _Null_unspecified imagePlaceholder;
@property (nonatomic, strong) UIFont * _Nonnull titleFont;
@property (nonatomic, strong) UIColor * _Nonnull titleColor;
@property (nonatomic, strong) UIImage * _Null_unspecified callToActionButton;
@property (nonatomic, strong) UIFont * _Nonnull contentMainFont;
- (nonnull instancetype)initWithContent:(NITContent * _Nonnull)content;
- (nonnull instancetype)initWithContent:(NITContent * _Nonnull)content manager:(NITManager * _Nullable)manager OBJC_DESIGNATED_INITIALIZER;
- (nullable instancetype)initWithCoder:(NSCoder * _Nonnull)aDecoder OBJC_DESIGNATED_INITIALIZER;
- (void)show;
- (void)showFromViewController:(UIViewController * _Nullable)fromViewController configureDialog:(void (^ _Nullable)(NITDialogController * _Nonnull))configureDialog;
- (void)showWithNavigationController:(UINavigationController * _Nonnull)navigationController;
- (void)viewDidLoad;
- (nonnull instancetype)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil SWIFT_UNAVAILABLE;
@end



enum NITCouponListViewControllerPresentCoupon : NSInteger;
enum NITCouponListViewControllerFilterOptions : NSInteger;
enum NITCouponListViewControllerFilterRedeemed : NSInteger;
@class NITCouponViewController;
@class UITableView;
@class UIView;
@class UITableViewCell;

SWIFT_CLASS_NAMED("NITCouponListViewController")
@interface NITCouponListViewController : NITBaseViewController <UITableViewDataSource, UITableViewDelegate>
@property (nonatomic) enum NITCouponListViewControllerPresentCoupon presentCoupon;
@property (nonatomic) enum NITCouponListViewControllerFilterOptions filterOption;
@property (nonatomic) enum NITCouponListViewControllerFilterRedeemed filterRedeemed;
@property (nonatomic, strong) UIImage * _Null_unspecified iconPlaceholder;
@property (nonatomic, strong) UIColor * _Nonnull expiredColor;
@property (nonatomic, strong) UIFont * _Nonnull expiredFont;
@property (nonatomic, strong) UIColor * _Nonnull disabledColor;
@property (nonatomic, strong) UIFont * _Nonnull disabledFont;
@property (nonatomic, strong) UIColor * _Nonnull validColor;
@property (nonatomic, strong) UIFont * _Nonnull validFont;
@property (nonatomic, strong) UIFont * _Nonnull titleFont;
@property (nonatomic, strong) UIColor * _Nonnull titleColor;
@property (nonatomic, strong) UIFont * _Nonnull titleDisabledFont;
@property (nonatomic, strong) UIColor * _Nonnull titleDisabledColor;
@property (nonatomic, strong) UIFont * _Nonnull titleExpiredFont;
@property (nonatomic, strong) UIColor * _Nonnull titleExpiredColor;
@property (nonatomic, strong) UIFont * _Nonnull valueFont;
@property (nonatomic, strong) UIColor * _Nonnull valueColor;
@property (nonatomic, strong) UIFont * _Nonnull valueDisabledFont;
@property (nonatomic, strong) UIColor * _Nonnull valueDisabledColor;
@property (nonatomic, strong) UIFont * _Nonnull valueExpiredFont;
@property (nonatomic, strong) UIColor * _Nonnull valueExpiredColor;
@property (nonatomic, copy) NSString * _Null_unspecified expiredText;
@property (nonatomic, copy) NSString * _Null_unspecified disabledText;
@property (nonatomic, copy) NSString * _Null_unspecified validText;
@property (nonatomic, copy) NSString * _Null_unspecified noCoupons;
@property (nonatomic, strong) UIImage * _Null_unspecified cellBackground;
@property (nonatomic, strong) UIImage * _Null_unspecified selectedCellBackground;
@property (nonatomic, copy) void (^ _Nullable couponViewControllerConfiguration)(NITCouponViewController * _Nonnull);
- (nonnull instancetype)init;
- (nonnull instancetype)initWithManager:(NITManager * _Nullable)manager OBJC_DESIGNATED_INITIALIZER;
- (nullable instancetype)initWithCoder:(NSCoder * _Nonnull)aDecoder OBJC_DESIGNATED_INITIALIZER;
- (void)show;
- (void)showFromViewController:(UIViewController * _Nullable)fromViewController;
- (void)showWithNavigationController:(UINavigationController * _Nonnull)navigationController;
- (void)viewDidLoad;
- (NSInteger)tableView:(UITableView * _Nonnull)tableView numberOfRowsInSection:(NSInteger)section SWIFT_WARN_UNUSED_RESULT;
- (NSInteger)numberOfSectionsInTableView:(UITableView * _Nonnull)tableView SWIFT_WARN_UNUSED_RESULT;
- (CGFloat)tableView:(UITableView * _Nonnull)tableView heightForHeaderInSection:(NSInteger)section SWIFT_WARN_UNUSED_RESULT;
- (UIView * _Nullable)tableView:(UITableView * _Nonnull)tableView viewForHeaderInSection:(NSInteger)section SWIFT_WARN_UNUSED_RESULT;
- (UITableViewCell * _Nonnull)tableView:(UITableView * _Nonnull)tableView cellForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath SWIFT_WARN_UNUSED_RESULT;
- (void)tableView:(UITableView * _Nonnull)tableView didSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
- (nonnull instancetype)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil SWIFT_UNAVAILABLE;
@end

typedef SWIFT_ENUM(NSInteger, NITCouponListViewControllerFilterOptions) {
  NITCouponListViewControllerFilterOptionsNone = 0b000,
  NITCouponListViewControllerFilterOptionsValid = 0b001,
  NITCouponListViewControllerFilterOptionsExpired = 0b010,
  NITCouponListViewControllerFilterOptionsValidAndExpired = 0b011,
  NITCouponListViewControllerFilterOptionsDisabled = 0b100,
  NITCouponListViewControllerFilterOptionsValidAndDisabled = 0b101,
  NITCouponListViewControllerFilterOptionsExpiredAndDisabled = 0b110,
  NITCouponListViewControllerFilterOptionsAll = 0b111,
};

typedef SWIFT_ENUM(NSInteger, NITCouponListViewControllerFilterRedeemed) {
  NITCouponListViewControllerFilterRedeemedHide = 0,
  NITCouponListViewControllerFilterRedeemedShow = 1,
};

typedef SWIFT_ENUM(NSInteger, NITCouponListViewControllerPresentCoupon) {
  NITCouponListViewControllerPresentCouponPopover = 0,
  NITCouponListViewControllerPresentCouponPush = 1,
  NITCouponListViewControllerPresentCouponCustom = 2,
};

typedef SWIFT_ENUM(NSInteger, NITCouponUIStatus) {
  NITCouponUIStatusValid = 0,
  NITCouponUIStatusDisabled = 1,
  NITCouponUIStatusExpired = 2,
};


SWIFT_CLASS_NAMED("NITCouponViewController")
@interface NITCouponViewController : NITBaseViewController
@property (nonatomic) BOOL drawSeparator;
@property (nonatomic) BOOL hideCloseButton;
@property (nonatomic, strong) UIImage * _Null_unspecified separatorImage;
@property (nonatomic, strong) UIColor * _Nonnull separatorBackgroundColor;
@property (nonatomic, strong) UIImage * _Null_unspecified iconPlaceholder;
@property (nonatomic, copy) NSString * _Null_unspecified expiredText;
@property (nonatomic, copy) NSString * _Null_unspecified disabledText;
@property (nonatomic, copy) NSString * _Null_unspecified validText;
@property (nonatomic, copy) NSString * _Null_unspecified fromText;
@property (nonatomic, copy) NSString * _Null_unspecified toText;
@property (nonatomic, strong) UIColor * _Nonnull couponValidColor;
@property (nonatomic, strong) UIColor * _Nonnull couponDisabledColor;
@property (nonatomic, strong) UIColor * _Nonnull couponExpiredColor;
@property (nonatomic, strong) UIFont * _Nonnull validFont;
@property (nonatomic, strong) UIFont * _Nonnull fromToFont;
@property (nonatomic, strong) UIFont * _Nonnull alternativeFont;
@property (nonatomic, strong) UIFont * _Nonnull titleFont;
@property (nonatomic, strong) UIColor * _Nonnull titleColor;
@property (nonatomic, strong) UIFont * _Nonnull descriptionFont;
@property (nonatomic, strong) UIColor * _Nonnull descriptionColor;
@property (nonatomic, strong) UIFont * _Nonnull serialFont;
@property (nonatomic, strong) UIColor * _Nonnull serialColor;
@property (nonatomic, strong) UIFont * _Nonnull valueFont;
@property (nonatomic, strong) UIColor * _Nonnull valueColor;
- (nonnull instancetype)initWithCoupon:(NITCoupon * _Nonnull)coupon;
- (nonnull instancetype)initWithCoupon:(NITCoupon * _Nonnull)coupon manager:(NITManager * _Nullable)manager OBJC_DESIGNATED_INITIALIZER;
- (nullable instancetype)initWithCoder:(NSCoder * _Nonnull)aDecoder OBJC_DESIGNATED_INITIALIZER;
- (void)show;
- (void)showFromViewController:(UIViewController * _Nullable)fromViewController configureDialog:(void (^ _Nullable)(NITDialogController * _Nonnull))configureDialog;
- (void)showWithNavigationController:(UINavigationController * _Nonnull)navigationController;
- (void)viewDidLoad;
- (void)viewWillAppear:(BOOL)animated;
- (void)viewWillDisappear:(BOOL)animated;
- (nonnull instancetype)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil SWIFT_UNAVAILABLE;
@end

enum CFAlertControllerBackgroundStyle : NSInteger;
enum CFAlertControllerContentPosition : NSInteger;

SWIFT_CLASS_NAMED("NITDialogController")
@interface NITDialogController : UIViewController
@property (nonatomic) enum CFAlertControllerBackgroundStyle backgroundStyle;
@property (nonatomic, strong) UIColor * _Nullable backgroundColor;
@property (nonatomic) enum CFAlertControllerContentPosition contentPosition;
- (void)viewDidLoad;
- (void)viewDidAppear:(BOOL)animated;
- (void)didReceiveMemoryWarning;
- (void)observeValueForKeyPath:(NSString * _Nullable)keyPath ofObject:(id _Nullable)object change:(NSDictionary<NSKeyValueChangeKey, id> * _Nullable)change context:(void * _Nullable)context;
- (nonnull instancetype)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil OBJC_DESIGNATED_INITIALIZER;
- (nullable instancetype)initWithCoder:(NSCoder * _Nonnull)aDecoder OBJC_DESIGNATED_INITIALIZER;
@end

typedef SWIFT_ENUM(NSInteger, CFAlertControllerBackgroundStyle) {
  CFAlertControllerBackgroundStylePlain = 0,
  CFAlertControllerBackgroundStyleBlur = 1,
};

typedef SWIFT_ENUM(NSInteger, CFAlertControllerContentPosition) {
  CFAlertControllerContentPositionMiddle = 0,
  CFAlertControllerContentPositionFull = 1,
};

@class UIGestureRecognizer;
@class UITouch;

@interface NITDialogController (SWIFT_EXTENSION(NearUIBinding)) <UIGestureRecognizerDelegate>
- (BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldReceiveTouch:(UITouch * _Nonnull)touch SWIFT_WARN_UNUSED_RESULT;
@end



typedef SWIFT_ENUM(NSInteger, NITFeedbackCommentVisibility) {
  NITFeedbackCommentVisibilityVisible = 0,
  NITFeedbackCommentVisibilityHidden = 1,
  NITFeedbackCommentVisibilityOnRating = 2,
};

@class NITFeedback;

SWIFT_CLASS_NAMED("NITFeedbackViewController")
@interface NITFeedbackViewController : NITBaseViewController
@property (nonatomic, copy) void (^ _Nullable feedbackSendCallback)(NITFeedbackViewController * _Nonnull, NSInteger, NSString * _Nullable, void (^ _Nonnull)(BOOL));
@property (nonatomic, strong) UIImage * _Null_unspecified sendButton;
@property (nonatomic, strong) UIImage * _Null_unspecified rateFullButton;
@property (nonatomic, strong) UIImage * _Null_unspecified rateEmptyButton;
@property (nonatomic, strong) UIColor * _Nonnull textColor;
@property (nonatomic, strong) UIFont * _Nullable textFont;
@property (nonatomic, strong) UIColor * _Nonnull errorColor;
@property (nonatomic, strong) UIFont * _Nullable errorFont;
@property (nonatomic, strong) UIImage * _Null_unspecified retryButton;
@property (nonatomic) enum NITFeedbackCommentVisibility commentVisibility;
@property (nonatomic, copy) NSString * _Null_unspecified closeText;
@property (nonatomic, copy) NSString * _Null_unspecified commentDescriptionText;
@property (nonatomic, copy) NSString * _Null_unspecified sendText;
@property (nonatomic, copy) NSString * _Null_unspecified errorText;
@property (nonatomic, copy) NSString * _Null_unspecified retryText;
@property (nonatomic, copy) NSString * _Null_unspecified okText;
@property (nonatomic) double disappearTime;
- (nonnull instancetype)initWithFeedback:(NITFeedback * _Nonnull)feedback;
- (nonnull instancetype)initWithFeedback:(NITFeedback * _Nonnull)feedback feedbackSendCallback:(void (^ _Nullable)(NITFeedbackViewController * _Nonnull, NSInteger, NSString * _Nullable, void (^ _Nonnull)(BOOL)))feedbackSendCallback;
- (nonnull instancetype)initWithFeedback:(NITFeedback * _Nonnull)feedback feedbackSendCallback:(void (^ _Nullable)(NITFeedbackViewController * _Nonnull, NSInteger, NSString * _Nullable, void (^ _Nonnull)(BOOL)))feedbackSendCallback manager:(NITManager * _Nullable)manager OBJC_DESIGNATED_INITIALIZER;
- (nullable instancetype)initWithCoder:(NSCoder * _Nonnull)aDecoder OBJC_DESIGNATED_INITIALIZER;
- (void)show;
- (void)showFromViewController:(UIViewController * _Nullable)fromViewController configureDialog:(void (^ _Nullable)(NITDialogController * _Nonnull))configureDialog;
- (void)viewDidLoad;
- (nonnull instancetype)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil SWIFT_UNAVAILABLE;
@end



typedef SWIFT_ENUM(NSInteger, NITPermissionsAutoCloseDialog) {
  NITPermissionsAutoCloseDialogOff = 0,
  NITPermissionsAutoCloseDialogOn = 1,
};

typedef SWIFT_ENUM(NSInteger, NITPermissionsAutoStartRadarType) {
  NITPermissionsAutoStartRadarTypeOff = 0,
  NITPermissionsAutoStartRadarTypeOn = 1,
};

typedef SWIFT_ENUM(NSInteger, NITPermissionsLocationType) {
  NITPermissionsLocationTypeAlways = 0,
  NITPermissionsLocationTypeWhenInUse = 1,
};

typedef SWIFT_ENUM(NSInteger, NITPermissionsType) {
  NITPermissionsTypeLocationOnly = 0,
  NITPermissionsTypeNotificationsOnly = 1,
  NITPermissionsTypeLocationAndNotifications = 2,
};


SWIFT_PROTOCOL("_TtP13NearUIBinding36NITPermissionsViewControllerDelegate_")
@protocol NITPermissionsViewControllerDelegate
@optional
- (void)locationGranted:(BOOL)granted;
- (void)notificationsGranted:(BOOL)granted;
- (void)dialogClosedWithLocationGranted:(BOOL)locationGranted notificationsGranted:(BOOL)notificationsGranted;
@end

enum NITPermissionsViewPermissions : NSInteger;
@class CBPeripheralManager;

SWIFT_CLASS("_TtC13NearUIBinding18NITPermissionsView")
@interface NITPermissionsView : UIView <CBPeripheralManagerDelegate, NITPermissionsViewControllerDelegate>
@property (nonatomic, copy) NSString * _Nullable messageText;
@property (nonatomic, strong) UIColor * _Nullable messageColor;
@property (nonatomic, strong) UIFont * _Nullable messageFont;
@property (nonatomic, copy) NSString * _Nullable buttonText;
@property (nonatomic, strong) UIColor * _Nullable buttonColor;
@property (nonatomic, strong) UIFont * _Nullable buttonFont;
@property (nonatomic, strong) UIColor * _Nullable permissionAvailableColor;
@property (nonatomic, strong) UIColor * _Nullable permissionNotAvailableColor;
@property (nonatomic) BOOL animateView;
@property (nonatomic) enum NITPermissionsViewPermissions permissionsRequired;
@property (nonatomic, copy) void (^ _Nullable callbackOnPermissions)(NITPermissionsView * _Nonnull);
@property (nonatomic, strong) UIImage * _Nullable buttonBackgroundImage;
- (nonnull instancetype)initWithFrame:(CGRect)frame OBJC_DESIGNATED_INITIALIZER;
- (nullable instancetype)initWithCoder:(NSCoder * _Nonnull)aDecoder OBJC_DESIGNATED_INITIALIZER;
- (void)peripheralManagerDidUpdateState:(CBPeripheralManager * _Nonnull)peripheral;
- (void)notificationsGranted:(BOOL)granted;
@end


SWIFT_CLASS_NAMED("NITPermissionsViewController")
@interface NITPermissionsViewController : NITBaseViewController
@property (nonatomic) enum NITPermissionsType type;
@property (nonatomic) enum NITPermissionsLocationType locationType;
@property (nonatomic) enum NITPermissionsAutoStartRadarType autoStartRadar;
@property (nonatomic) enum NITPermissionsAutoCloseDialog autoCloseDialog;
@property (nonatomic, strong) UIImage * _Null_unspecified unknownButton;
@property (nonatomic, strong) UIImage * _Null_unspecified grantedButton;
@property (nonatomic, strong) UIImage * _Null_unspecified grantedIcon;
@property (nonatomic, strong) UIImage * _Null_unspecified headerImage;
@property (nonatomic, strong) UIColor * _Null_unspecified textColor;
@property (nonatomic, copy) NSString * _Null_unspecified locationText;
@property (nonatomic, copy) NSString * _Null_unspecified notificationsText;
@property (nonatomic, copy) NSString * _Null_unspecified explainText;
@property (nonatomic, copy) NSString * _Null_unspecified closeText;
@property (nonatomic, copy) NSString * _Null_unspecified notNowText;
@property (nonatomic, weak) id <NITPermissionsViewControllerDelegate> _Nullable delegate;
- (void)viewDidLoad;
- (void)viewWillDisappear:(BOOL)animated;
- (BOOL)checkPermissions SWIFT_WARN_UNUSED_RESULT;
- (void)didReceiveMemoryWarning;
- (nonnull instancetype)init;
- (nonnull instancetype)initWithLocationType:(enum NITPermissionsLocationType)locationType;
- (nonnull instancetype)initWithType:(enum NITPermissionsType)type;
- (nonnull instancetype)initWithType:(enum NITPermissionsType)type locationType:(enum NITPermissionsLocationType)locationType autoStartRadar:(enum NITPermissionsAutoStartRadarType)autoStartRadar autoCloseDialog:(enum NITPermissionsAutoCloseDialog)autoCloseDialog OBJC_DESIGNATED_INITIALIZER;
- (nullable instancetype)initWithCoder:(NSCoder * _Nonnull)aDecoder OBJC_DESIGNATED_INITIALIZER;
- (void)show;
/// Present permissions view controller from the rootViewController if it exists
- (void)showWithConfigureDialog:(void (^ _Nullable)(NITDialogController * _Nonnull))configureDialog;
/// Present permissions view controller from a view controller
/// \param fromViewController view controller used to present the permissions view controller
///
- (void)showFromViewController:(UIViewController * _Nonnull)fromViewController configureDialog:(void (^ _Nullable)(NITDialogController * _Nonnull))configureDialog;
- (nonnull instancetype)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil SWIFT_UNAVAILABLE;
@end




typedef SWIFT_ENUM(NSInteger, NITPermissionsViewPermissions) {
  NITPermissionsViewPermissionsLocation = 0b001,
  NITPermissionsViewPermissionsNotifications = 0b010,
  NITPermissionsViewPermissionsBluetooth = 0b100,
  NITPermissionsViewPermissionsLocationAndNotifications = 0b011,
  NITPermissionsViewPermissionsNotificationAndBluetooth = 0b110,
  NITPermissionsViewPermissionsLocationAndBluetooth = 0b101,
  NITPermissionsViewPermissionsAll = 0b111,
};





SWIFT_MODULE_NAMESPACE_POP
#pragma clang diagnostic pop
