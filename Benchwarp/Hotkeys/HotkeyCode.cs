namespace Benchwarp.Hotkeys;

public readonly record struct HotkeyCode(HotkeyInput First, HotkeyInput Second)
{
    public static HotkeyCode None { get; } = new(HotkeyInput.None, HotkeyInput.None);
    public static HotkeyCode operator +(HotkeyCode code, HotkeyInput input) => new(code.Second, input);

    public bool IsComplete => !First.IsNone && !Second.IsNone;

    public bool TryGetLetterNumCode(out int firstIndex, out int secondIndex)
    {
        if (First.IsLetter && Second.IsNum)
        {
            firstIndex = First.Num;
            secondIndex = Second.Num;
            return true;
        }
        else
        {
            firstIndex = 0;
            secondIndex = 0;
            return false;
        }
    }

    public bool TryGetNumericCode(out int code)
    {
        if (First.IsNum && Second.IsNum)
        {
            code = First.Num * 10 + Second.Num;
            return true;
        }
        else
        {
            code = 0;
            return false;
        }
    }

    public bool TryGetStringCode(out string code)
    {
        if (First.IsLetter && Second.IsLetter)
        {
            code = $"{First.Letter}{Second.Letter}";
            return true;
        }
        else
        {
            code = string.Empty;
            return false;
        }
    }
}
