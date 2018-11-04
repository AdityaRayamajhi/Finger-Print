namespace Com.Samsung.Android.Sdk.Pass {
  public enum SpassFingerprintStatus {
    [global::Android.Runtime.IntDefinition (null, JniField = "com/samsung/android/sdk/pass/SpassFingerprint.STATUS_AUTHENTIFICATION_SUCCESS")]
    Success = 0,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/samsung/android/sdk/pass/SpassFingerprint.STATUS_TIMEOUT_FAILED")]
    TimeoutFailed = 4,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/samsung/android/sdk/pass/SpassFingerprint.STATUS_SENSOR_FAILED")]
    SensorFailed = 7,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/samsung/android/sdk/pass/SpassFingerprint.STATUS_USER_CANCELLED")]
    UserCancelled = 8,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/samsung/android/sdk/pass/SpassFingerprint.STATUS_BUTTON_PRESSED")]
    ButtonPressed = 9,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/samsung/android/sdk/pass/SpassFingerprint.STATUS_QUALITY_FAILED")]
    QualityFailed = 12,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/samsung/android/sdk/pass/SpassFingerprint.STATUS_USER_CANCELLED_BY_TOUCH_OUTSIDE")]
    UserCancelledByTouchOutside = 13,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/samsung/android/sdk/pass/SpassFingerprint.STATUS_AUTHENTIFICATION_FAILED")]
    Failed = 16,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/samsung/android/sdk/pass/SpassFingerprint.STATUS_OPERATION_DENIED")]
    OperationDenied = 51,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/samsung/android/sdk/pass/SpassFingerprint.STATUS_AUTHENTIFICATION_PASSWORD_SUCCESS")]
    PasswordSuccess = 100,
  }
}
