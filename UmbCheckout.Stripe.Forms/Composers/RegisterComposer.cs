using UmbCheckout.Stripe.Forms.Workflows;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Forms.Core.Providers.Extensions;

namespace UmbCheckout.Stripe.Forms.Composers
{
    public class RegisterComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.FormsWorkflows().Add<SendToUmbCheckoutWorkflow>();
        }
    }
}
