namespace PaymentCenterTestTask.Data.Messages {
    public enum MessageType {
        Request,
        Response,
        Event,
        Auth,
        AuthResult,
        ReAuth,
        ReAuthResult,
        Logout,
        SessionProlongate,
        SessionValidate,
        RequireConfirm,
        CancelConfirmOperation,
        RenewConfirmationCode,
        Error
    }
}