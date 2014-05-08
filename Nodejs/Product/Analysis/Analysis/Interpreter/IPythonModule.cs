﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

using System.Collections.Generic;

namespace Microsoft.NodejsTools.Interpreter {
    /// <summary>
    /// Represents a Python module which members can be imported from.
    /// </summary>
    public interface IPythonModule : IMemberContainer, IMember {
        string Name {
            get;
        }

        IEnumerable<string> GetChildrenModules();

        void Imported(IModuleContext context);

        /// <summary>
        /// The documentation of the module
        /// 
        /// New in 1.1.
        /// </summary>
        string Documentation {
            get;
        }
    }
}