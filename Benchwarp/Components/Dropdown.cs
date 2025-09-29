using Benchwarp.Data;
using GlobalEnums;
using UnityEngine;
using UnityEngine.UI;

namespace Benchwarp.Components
{
    public class Dropdown : MonoBehaviour
    {
        public string dropdownName = "";
        public List<BenchComponent> benches = new([]);
        public List<GameObject> buttons = new([]);
        public bool open = false;
        public int page = 1;

        public void Init(GameObject canvas, string name, List<BenchData> benches)
        {
            dropdownName = name;

            int btnOffsetX = GUIController.btnOffsetX;
            int btnOffsetY = GUIController.baseDropdownYOffset;
            int btnHeight = GUIController.btnHeight;

            for (int i = 0; i < benches.Count; i++)
            {
                BenchData benchData = benches[i];
                buttons.Add(GUIController.BuildButton(canvas, benchData.BenchName, 0, -(btnHeight + btnOffsetY + (btnOffsetY + btnHeight) * i), GUIController.TopLeftCorner, false));
                BenchComponent bench = buttons[i].AddComponent<BenchComponent>();
                bench.Init(benchData);
                buttons[i].GetComponent<Button>().onClick.AddListener(bench.SetBench);
            }

            DropdownInteract(open);
        }

        public void ToggleDropdown()
        {
            if (open)
            {
                open = false;
            }
            else
            {
                open = true;
            }
            DropdownInteract(open);
        }

        public void DropdownInteract(bool interact)
        {
            foreach (var button in buttons)
            {
                button.SetActive(interact);
            }
        }
    }
}
