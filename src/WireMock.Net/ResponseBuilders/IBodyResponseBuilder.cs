﻿using System.Text;
using JetBrains.Annotations;

namespace WireMock.ResponseBuilders
{
    /// <summary>
    /// The BodyResponseBuilder interface.
    /// </summary>
    public interface IBodyResponseBuilder : ITransformResponseBuilder
    {
        /// <summary>
        /// The with body.
        /// </summary>
        /// <param name="body">The body.</param>
        /// <returns>A <see cref="ITransformResponseBuilder"/>.</returns>
        ITransformResponseBuilder WithBody([NotNull] string body);

        /// <summary>
        /// The with body as base64.
        /// </summary>
        /// <param name="bodyAsbase64">The body asbase64.</param>
        /// <param name="encoding">The Encoding.</param>
        /// <returns>A <see cref="ITransformResponseBuilder"/>.</returns>
        ITransformResponseBuilder WithBodyAsBase64([NotNull] string bodyAsbase64, [CanBeNull] Encoding encoding = null);
    }
}