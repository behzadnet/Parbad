﻿using Parbad.Providers;

namespace Parbad
{
    /// <summary>
    /// Describes the invoice which sent by the gateway. You can compare its data with your database and also cancel the payment operation if you need.
    /// </summary>
    public interface IPaymentVerifyingContext
    {
        /// <summary>
        /// The gateway, which
        /// </summary>
        Gateway Gateway { get; }

        /// <summary>
        /// Order Number of payment.
        /// </summary>
        long OrderNumber { get; }

        /// <summary>
        /// Reference ID of payment.
        /// </summary>
        string ReferenceId { get; }

        /// <summary>
        /// Cancel the operation.
        /// </summary>
        /// <param name="reason">The reason for cancelling the operation.</param>
        void Cancel(string reason = null);
    }
}