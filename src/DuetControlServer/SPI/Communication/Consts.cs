namespace DuetControlServer.SPI.Communication
{
    /// <summary>
    /// Static class holding SPI transfer constants
    /// </summary>
    public static class Consts
    {
        /// <summary>
        /// Unique format code for binary SPI transfers
        /// </summary>
        /// <remarks>Must be different from any other used format code (0x3E = DuetWiFiServer)</remarks>
        public const byte FormatCode = 0x5F;

        /// <summary>
        /// Format code indicating that RRF is generally available but has not processed the last transfer yet
        /// </summary>
        public const byte FormatCodeStandalone = 0x60;

        /// <summary>
        /// Unique format code that is not used anywhere else
        /// </summary>
        public const byte InvalidFormatCode = 0xC9;

        /// <summary>
        /// Used protocol version. This is incremented whenever the protocol details change
        /// </summary>
        public const ushort ProtocolVersion = 5;

        /// <summary>
        /// Default size of a data transfer buffer
        /// </summary>
        public const int BufferSize = 8192;

        /// <summary>
        /// Maximum length of a whole-line comment to send to RRF
        /// </summary>
        public const int MaxCommentLength = 100;

        /// <summary>
        /// Maximum length of an expression
        /// </summary>
        public const int MaxExpressionLength = 256;

        /// <summary>
        /// Maximum lenght of a variable name
        /// </summary>
        public const int MaxVariableLength = 120;

        /// <summary>
        /// Maximum number of evaluation and variable requests to send per transfer
        /// </summary>
        public const int MaxEvaluationRequestsPerTransfer = 32;

        /// <summary>
        /// Size of the header prefixing a buffered code
        /// </summary>
        public const int BufferedCodeHeaderSize = 4;

        /// <summary>
        /// Value used by RepRapFirmware to represent an invalid file position
        /// </summary>
        public const uint NoFilePosition = 0xFFFFFFFF;

        /// <summary>
        /// Size of each transmitted IAP binary segment (must be a multiple of IFLASH_PAGE_SIZE)
        /// </summary>
        public const int IapSegmentSize = 1536;

        /// <summary>
        /// Time to wait when the IAP reboots to the main firmware
        /// </summary>
        public const int IapBootDelay = 500;

        /// <summary>
        /// Timeout when waiting for a response from IAP
        /// </summary>
        public const int IapTimeout = 8000;

        /// <summary>
        /// Size of each transmitted firmware binary segment (must be equal to blockReadSize in the IAP project)
        /// </summary>
        public const int FirmwareSegmentSize = 2048;

        /// <summary>
        /// Delay to await after the last firmware segment has been written (in ms)
        /// </summary>
        public const int FirmwareFinishedDelay = 750;

        /// <summary>
        /// Time to wait when the IAP reboots to the main firmware
        /// </summary>
        public const int IapRebootDelay = 2000;
    }
}
