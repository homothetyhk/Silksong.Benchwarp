namespace Benchwarp.Hotkeys;

public readonly record struct HotkeyInput(HotkeyType Type, int Num)
{
    public static HotkeyInput None { get; } = new(HotkeyType.None, 0);
    public bool IsNone => Type == HotkeyType.None;
    public bool IsLetter => Type == HotkeyType.Letter;
    public bool IsNum => Type == HotkeyType.Number;


    public char Letter => (char)('A' + Num);
}
