﻿using System.Numerics;
using FFXIVClientStructs.FFXIV.Client.Graphics;

namespace KamiToolKit.Extensions;

public static class ByteColorExtensions {
    public static Vector4 ToVector4(this ByteColor color)
        => new(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
}