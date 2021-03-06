// Commands.cs
// 
// Copyright © 2008 David Paleino <d.paleino@gmail.com>
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;

namespace OpenPGP {
	/// <summary>
	/// Supported commands.
	/// </summary>
	public enum Commands {
//		Sign,
//		Encrypt,
//		Decrypt,
//		SignAndEncrypt,
//		Import,
		/// <summary>
		/// List the public key
		/// </summary>
		List,
		/// <summary>
		/// List secret keys
		/// </summary>
		ListSecretKeys,
		/// <summary>
		/// Export the public key
		/// </summary>
		Export,
		/// <summary>
		/// Export the secret key
		/// </summary>
		ExportSecretKey,
//		AddKey,
//		SignKey,
//		DelKey,
	}
}
