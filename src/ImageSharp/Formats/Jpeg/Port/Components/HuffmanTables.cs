﻿// <copyright file="HuffmanTables.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp.Formats.Jpeg.Port.Components
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines a pair of huffman tables
    /// </summary>
    internal sealed class HuffmanTables : IDisposable
    {
        private readonly HuffmanTable[] tables = new HuffmanTable[4];

        /// <summary>
        /// Gets or sets the table at the given index.
        /// </summary>
        /// <param name="index">The index</param>
        /// <returns>The <see cref="List{HuffmanBranch}"/></returns>
        public HuffmanTable this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return this.tables[index];
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this.tables[index] = value;
            }
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            for (int i = 0; i < this.tables.Length; i++)
            {
                this.tables[i].Dispose();
            }
        }
    }
}