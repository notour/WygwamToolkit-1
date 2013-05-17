﻿//-----------------------------------------------------------------------
// <copyright file="BaseViewModel.cs" company="Wygwam">
//     Copyright (c) 2013 Wygwam.
//     Licensed under the Microsoft Public License (Ms-PL) (the "License");
//     you may not use this file except in compliance with the License.
//     You may obtain a copy of the License at
//
//         http://opensource.org/licenses/Ms-PL.html
//
//     Unless required by applicable law or agreed to in writing, software
//     distributed under the License is distributed on an "AS IS" BASIS,
//     WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//     See the License for the specific language governing permissions and
//     limitations under the License.
// </copyright>
//-----------------------------------------------------------------------

namespace Wygwam.Windows.ViewModels
{
    using System.Threading.Tasks;

    /// <summary>
    /// Serves as a base for view model classes.
    /// </summary>
    public class BaseViewModel : BindableBase
    {
        /// <summary>
        /// Called when the underlying view has finished loading.
        /// </summary>
        /// <returns>An instance of <see cref="System.Threading.Tasks.Task"/> that helps in
        /// asynchronous programming.</returns>
        public virtual Task OnLoaded()
        {
            return Task.FromResult(false);
        }

        /// <summary>
        /// Reloads this instance.
        /// </summary>
        /// <returns>An instance of <see cref="System.Threading.Tasks.Task"/> that helps in
        /// asynchronous programming.</returns>
        public virtual Task Reload()
        {
            return Task.FromResult(false);
        }
    }
}
