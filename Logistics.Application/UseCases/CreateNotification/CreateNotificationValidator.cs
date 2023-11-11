using FluentValidation;

public sealed class CreateNotificationValidator : AbstractValidator<CreateNotificationRequest>
{
    public CreateNotificationValidator()
    {
        //RuleFor(x => x.NotificationId).NotEmpty().MaximumLength(50);
        //RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
    }
}