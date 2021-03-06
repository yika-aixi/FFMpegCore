﻿using System.Threading;
using System.Threading.Tasks;

namespace FFMpegCore.Pipes
{
    /// <summary>
    /// Interface for Video frame
    /// </summary>
    public interface IVideoFrame
    {
        int Width { get; }
        int Height { get; }
        string Format { get; }

        void Serialize(System.IO.Stream pipe);
        Task SerializeAsync(System.IO.Stream pipe, CancellationToken token);
    }
}
