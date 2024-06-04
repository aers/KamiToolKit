﻿using System.Numerics;
using Dalamud.Game.Text.SeStringHandling;
using Dalamud.Memory;
using Dalamud.Utility.Numerics;
using FFXIVClientStructs.FFXIV.Component.GUI;
using KamiToolKit.Extensions;

namespace KamiToolKit;

public unsafe class TextNode() : NodeBase<AtkTextNode>(NodeType.Text) {
    public Vector4 TextColor {
        get => InternalNode->TextColor.ToVector4();
        set => InternalNode->TextColor = value.ToByteColor();
    }

    public Vector4 OutlineColor {
        get => InternalNode->EdgeColor.ToVector4();
        set => InternalNode->EdgeColor = value.ToByteColor();
    }

    public Vector4 BackgroundColor {
        get => InternalNode->BackgroundColor.ToVector4();
        set => InternalNode->BackgroundColor = value.ToByteColor();
    }

    public SeString SeString {
        get => MemoryHelper.ReadSeStringNullTerminated((nint) InternalNode->GetText());
        set => InternalNode->SetText(value.Encode());
    }

    public string String {
        get => MemoryHelper.ReadStringNullTerminated((nint) InternalNode->GetText());
        set => InternalNode->SetText(value);
    }

    public uint SelectStart {
        get => InternalNode->SelectStart;
        set => InternalNode->SelectStart = value;
    }

    public uint SelectEnd {
        get => InternalNode->SelectEnd;
        set => InternalNode->SelectEnd = value;
    }

    public AlignmentType AlignmentType {
        get => InternalNode->AlignmentType;
        set => InternalNode->AlignmentType = value;
    }

    public FontType FontType {
        get => InternalNode->FontType;
        set => InternalNode->FontType = value;
    }

    public TextFlags TextFlags {
        get => (TextFlags) InternalNode->TextFlags;
        set => InternalNode->TextFlags = (byte) value;
    }

    public TextFlags2 TextFlags2 {
        get => (TextFlags2) InternalNode->TextFlags2;
        set => InternalNode->TextFlags2 = (byte) value;
    }

    public uint FontSize {
        get => InternalNode->FontSize;
        set => InternalNode->FontSize = (byte) value;
    }

    public uint LineSpacing {
        get => InternalNode->LineSpacing;
        set => InternalNode->LineSpacing = (byte) value;
    }
    
    public uint CharSpacing {
        get => InternalNode->CharSpacing;
        set => InternalNode->CharSpacing = (byte) value;
    }

    public uint TextId {
        get => InternalNode->TextId;
        set => InternalNode->TextId = value;
    }

    public void SetNumber(int number, bool showCommas = false, bool showPlusSign = false, int digits = 0, bool zeroPad = false)
        => InternalNode->SetNumber(number, showCommas, showPlusSign, (byte) digits, zeroPad);
}