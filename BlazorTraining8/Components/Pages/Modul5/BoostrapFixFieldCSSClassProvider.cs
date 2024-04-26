using Microsoft.AspNetCore.Components.Forms;

namespace BlazorTraining8.Components.Pages.Modul5
{
    public class BoostrapFixFieldCSSClassProvider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
           bool IsInValid= editContext.GetValidationMessages(fieldIdentifier).Any();
            return IsInValid ? "is-invalid" : "is-valid";
            
        }
    }
}
