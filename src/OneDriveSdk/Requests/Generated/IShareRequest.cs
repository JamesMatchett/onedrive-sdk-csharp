// ------------------------------------------------------------------------------
//  Copyright (c) 2015 Microsoft Corporation
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using System.Threading.Tasks;

    /// <summary>
    /// The interface IShareRequest.
    /// </summary>
    public partial interface IShareRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Share using PUT.
        /// </summary>
        /// <param name="share">The Share to create.</param>
        /// <returns>The created Share.</returns>
        Task<Share> CreateAsync(Share share);

        /// <summary>
        /// Deletes the specified Share.
        /// </summary>
        /// <param name="share">The Share to delete.</param>
        /// <returns>The task to await.</returns>
        Task DeleteAsync();

        /// <summary>
        /// Gets the Share.
        /// </summary>
        /// <returns>The Share.</returns>
        Task<Share> GetAsync();

        /// <summary>
        /// Updates the specified Share using PATCH.
        /// </summary>
        /// <param name="share">The Share to update.</param>
        /// <returns>The updated Share.</returns>
        Task<Share> UpdateAsync(Share share);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IShareRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IShareRequest Select(string value);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IShareRequest Top(int value);
    }
}
