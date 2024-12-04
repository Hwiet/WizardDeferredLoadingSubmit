using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;

namespace Wizard.Pages;

public partial class Home
{
    [Inject]
    public IDialogService DialogService { get; set; } = default!;

    public IntroModel IntroModel { get; set; } = new();

    public GetStartedModel GetStartedModel { get; set; } = new();

    public SetBudgetModel SetBudgetModel { get; set; } = new();

    public SummaryModel SummaryModel { get; set; } = new();

    private async Task ShowSubmitMessageAsync(string message)
    {
        var dialogRef = await DialogService.ShowSuccessAsync(message);
        await dialogRef.Result;
    }
}
