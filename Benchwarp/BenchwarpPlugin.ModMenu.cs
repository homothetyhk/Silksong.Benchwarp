using Silksong.ModMenu.Elements;
using Silksong.ModMenu.Plugin;

namespace Benchwarp
{
    public partial class BenchwarpPlugin : IModMenuCustomElement
    {
        internal TextButton ModMenuEntryButton
        {
            get
            {
                if (field is null || !field.MenuButton)
                {
                    new ConfigEntryFactory().GenerateEntryButton("Benchwarp", this, out SelectableElement? sel);
                    field = (TextButton)sel!;
                }
                return field;
            }
        }

        SelectableElement IModMenuCustomElement.BuildCustomElement()
        {
            return ModMenuEntryButton;
        }
    }
}
