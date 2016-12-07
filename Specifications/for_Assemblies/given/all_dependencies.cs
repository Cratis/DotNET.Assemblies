/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Cratis.Assemblies;
using Machine.Specifications;
using Moq;

namespace Specifications.for_Assemblies.given
{
    public class all_dependencies
    {
        protected static Mock<IAssemblyProvider>    assembly_provider_mock;

        Establish context = () => assembly_provider_mock = new Mock<IAssemblyProvider>();
    }
}