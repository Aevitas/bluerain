﻿// Copyright (C) 2013-2015 aevitas
// See the file COPYING for copying permission.

using System;

// These custom exception types are provided to enable framework implementers to catch operations specific to BlueRain.
// When writing extensions, you should always try to throw these whenever possible.

namespace BlueRain.Common
{
    /// <summary>
    /// Base exception type thrown by BlueRain.
    /// </summary>
    public class BlueRainException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlueRainException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public BlueRainException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueRainException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public BlueRainException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    /// <summary>
    /// Exception thrown when a reading operation fails within the BlueRain framework.
    /// </summary>
    public class BlueRainReadException : BlueRainException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlueRainReadException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public BlueRainReadException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueRainReadException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public BlueRainReadException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    /// <summary>
    /// Exception thrown when a writing operation fails within the BlueRain framework.
    /// </summary>
    public class BlueRainWriteException : BlueRainException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlueRainWriteException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public BlueRainWriteException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueRainWriteException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public BlueRainWriteException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}