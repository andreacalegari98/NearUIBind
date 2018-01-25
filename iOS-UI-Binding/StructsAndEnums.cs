using System;
using ObjCRuntime;

namespace NearUI
{

    [Native]
    public enum NITFeedbackCommentVisibility : long
    {
        Visible = 0,
        Hidden = 1,
        OnRating = 2
    }

    [Native]
    public enum NITPermissionsAutoCloseDialog : long
    {
        ff = 0,
        n = 1
    }

    [Native]
    public enum NITPermissionsAutoStartRadarType : long
    {
        ff = 0,
        n = 1
    }

    [Native]
    public enum NITPermissionsLocationType : long
    {
        Always = 0,
        WhenInUse = 1
    }

    [Native]
    public enum NITPermissionsType : long
    {
        LocationOnly = 0,
        NotificationsOnly = 1,
        LocationAndNotifications = 2
    }

    [Native]
    public enum NITPermissionsViewPermissions : long
    {
        Location = 1,
        Notifications = 2,
        Bluetooth = 4,
        LocationAndNotifications = 3,
        NotificationAndBluetooth = 6,
        LocationAndBluetooth = 5,
        All = 7
    }

    [Native]
    public enum NITCouponListViewControllerPresentCoupon : long
    {
        Popover = 0,
        Push = 1,
        Custom = 2
    }

    [Native]
    public enum NITCouponListViewControllerFilterOptions : long
    {
        None = 0,
        Valid = 1,
        Expired = 2,
        ValidAndExpired = 3,
        Disabled = 4,
        ValidAndDisabled = 5,
        ExpiredAndDisabled = 6,
        All = 7
    }

    [Native]
    public enum NITCouponListViewControllerFilterRedeemed : long
    {
        Hide = 0,
        Show = 1
    }

    [Native]
    public enum CFAlertControllerBackgroundStyle : long
    {
        Plain = 0,
        Blur = 1
    }

    [Native]
    public enum CFAlertControllerContentPosition : long
    {
        Middle = 0,
        Full = 1
    }

}