

namespace Content.Shared._Goobstation.PinpointerOverwrite;

public sealed partial class PinpointerOverwriteComponent : Component
{
    /// <summary>
    ///     Target component: target name
    /// </summary>
    [DataField("target"), ViewVariables(VVAccess.ReadWrite)]
    public Dictionary<string, string> Targer;
}

