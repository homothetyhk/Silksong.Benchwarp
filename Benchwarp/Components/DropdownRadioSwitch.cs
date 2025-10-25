﻿using UnityEngine;
using UnityEngine.UI;

namespace Benchwarp.Components;

public class DropdownRadioSwitch : MonoBehaviour
{
    private List<(GameObject go, Text text)> buttons = [];
    private List<string> options = [];
    private bool open = false;
    private int columns = 1;
    private int maxRows = 6;
    public Action<string>? onSelectionChanged;
    public Action? onSelectionCanceled;
    public int SelectedIndex { get; private set; }
    public bool Open => open;
    public int Capacity => maxRows * columns;

    public void Init(GameObject canvas, string name, int columns, int maxRows)
    {
        this.columns = columns;
        this.maxRows = maxRows;

        int btnOffsetX = GUIController.btnOffsetX;
        int btnOffsetY = GUIController.baseDropdownYOffset;
        int btnHeight = GUIController.btnHeight;
        int btnWidth = GUIController.btnWidth;

        int HorizontalOffset(int column)
        {
            bool odd = columns % 2 == 1;
            if (odd)
            {
                return (column - columns / 2) * btnWidth;
            }
            else
            {
                return (column - columns / 2) * btnWidth + btnWidth / 2;
            }
        }

        int VerticalOffset(int row)
        {
            return -(btnHeight + btnOffsetY + (btnOffsetY + btnHeight) * row);
        }

        for (int r = 0; r < maxRows; r++)
        {
            for (int c = 0;  c < columns; c++)
            {
                int index = r * columns + c;
                string btnName = $"{name} ({index})";
                GameObject go = GUIController.BuildButton(canvas, btnName, HorizontalOffset(c), VerticalOffset(r), GUIController.TopLeftCorner, bg: false);
                Text text = go.transform.Find("ButtonText").GetComponent<Text>();
                go.GetComponent<Button>().onClick.AddListener(() => Select(index));
                buttons.Add((go, text));
            }
        }
        HideAll();
    }

    public void Deselect()
    {
        if (SelectedIndex >= 0)
        {
            buttons[SelectedIndex].text.color = Color.white;
            SelectedIndex = -1;
            onSelectionCanceled?.Invoke();
        }
    }

    public void Select(int index)
    {
        Deselect();
        buttons[index].text.color = Color.yellow;
        SelectedIndex = index;
        onSelectionChanged?.Invoke(options[index]);
    }

    public void Select(string option)
    {
        int index = options.IndexOf(option);
        if (index == -1) throw new KeyNotFoundException(option);
        Select(index);
    }

    public void Depopulate()
    {
        Deselect();
        options.Clear();
        HideAll();
    }

    public void Populate(IEnumerable<string> strs, bool autoOpen)
    {
        Depopulate();
        int i = 0;
        try
        {
            foreach (string str in strs)
            {
                options.Add(str);
                buttons[i++].text.text = str;
            }
        }
        catch (Exception e)
        {
            LogError($"Collection of size {strs.Count()} added to radio switch of capacity {Capacity}.");
            LogError(e);
        }
        
        if (autoOpen) Show();
    }

    public void HideAll()
    {
        open = false;
        foreach ((GameObject go, _) in buttons) go.SetActive(false);
    }

    public void Show()
    {
        open = true;
        for (int i = 0; i < options.Count; i++) buttons[i].go.SetActive(true);
    }

    public void ToggleDropdown()
    {
        if (open) HideAll();
        else Show();
    }

}
