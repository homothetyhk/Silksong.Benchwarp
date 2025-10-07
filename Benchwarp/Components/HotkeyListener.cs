using Benchwarp.Data;
using UnityEngine;

namespace Benchwarp.Components
{
    public class HotkeyListener : MonoBehaviour
    {
        private HotkeyCode code;

        private void ClearCode() => code = HotkeyCode.None;
        private void ClipCode() => code = new(HotkeyInput.None, code.Second);

        public void Update() => DetectHotkeys();

        public void OnEnable() => ClearCode();

        private void DetectHotkeys()
        {
            if (!(GUIController.Instance.IsDisplaying && BenchwarpPlugin.ConfigSettings.EnableHotkeys))
            {
                return;
            }

            for (KeyCode letter = KeyCode.A; letter <= KeyCode.Z; letter++)
            {
                if (Input.GetKeyDown(letter))
                {
                    code += new HotkeyInput(HotkeyType.Letter, letter - KeyCode.A);
                }
            }
            for (KeyCode alpha = KeyCode.Alpha0; alpha <= KeyCode.Alpha9; alpha++)
            {
                if (Input.GetKeyDown(alpha))
                {
                    code += new HotkeyInput(HotkeyType.Number, alpha - KeyCode.Alpha0);
                }
            }
            for (KeyCode pad = KeyCode.Keypad0; pad <= KeyCode.Keypad9; pad++)
            {
                if (Input.GetKeyDown(pad))
                {
                    code += new HotkeyInput(HotkeyType.Number, pad - KeyCode.Keypad0);
                }
            }

            if (code.IsComplete)
            {
                if (code.TryGetLetterNumCode(out int i1, out int i2))
                {
                    if (HotkeyActions.TryDoHotkeyAction(i1, i2)) ClearCode();
                    else ClipCode();
                }
                else if (code.TryGetStringCode(out string s))
                {
                    if (HotkeyActions.TryDoHotkeyAction(s)) ClearCode();
                    else ClipCode();
                }
            }
        }
    }
}
