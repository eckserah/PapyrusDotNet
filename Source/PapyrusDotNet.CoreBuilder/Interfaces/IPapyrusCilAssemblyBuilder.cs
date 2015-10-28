﻿/*
    This file is part of PapyrusDotNet.

    PapyrusDotNet is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    PapyrusDotNet is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with PapyrusDotNet.  If not, see <http://www.gnu.org/licenses/>.
	
	Copyright 2015, Karl Patrik Johansson, zerratar@gmail.com
 */

using System.Collections.Generic;
using Mono.Cecil;

namespace PapyrusDotNet.CoreBuilder.Interfaces
{
    /// <summary>
    /// Used for building .NET Assemblies using Papyrus as input
    /// </summary>
    public interface IPapyrusCilAssemblyBuilder
    {
        /// <summary>
        /// The root/main Module used in the output Assembly
        /// </summary>
        ModuleDefinition MainModule { get; set; }

        /// <summary>
        /// Builds a .NET Assembly using the input Papyrus Source
        /// </summary>
        /// <param name="inputSourceFiles"></param>
        void BuildAssembly(string[] inputSourceFiles);

        /// <summary>
        /// 
        /// </summary>        
        /// <param name="forType"></param>
        void AddEmptyConstructor(TypeDefinition forType);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="forType"></param>
        void AddVirtualOnInit(TypeDefinition forType);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="function"></param>
        void CreateEmptyFunctionBody(ref MethodDefinition function);

        /// <summary>
        /// 
        /// </summary>
        List<string> ReservedTypeNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<TypeReference> AddedTypeReferences { get; set; }
    }
}
