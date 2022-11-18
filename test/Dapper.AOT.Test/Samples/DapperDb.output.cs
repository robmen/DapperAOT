// Input code has 2 diagnostics from 'Samples/DapperDb.input.cs':
// Samples/DapperDb.input.cs(136,17): error CS0012: The type 'List<>' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Collections, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'.
// Samples/DapperDb.input.cs(141,17): error CS0012: The type 'List<>' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Collections, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'.
// Output code has 3 diagnostics from 'Samples/DapperDb.input.cs':
// Samples/DapperDb.input.cs(98,45): error CS8795: Partial method 'DapperDb.ReadFortunesRows()' must have an implementation part because it has accessibility modifiers.
// Samples/DapperDb.input.cs(136,17): error CS0012: The type 'List<>' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Collections, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'.
// Samples/DapperDb.input.cs(141,17): error CS0012: The type 'List<>' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Collections, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'.

#nullable enable
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by:
//     Dapper.CodeAnalysis.CommandGenerator vN/A
// Changes to this file may cause incorrect behavior and
// will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#region Designer generated code
namespace Dapper.Samples.DapperDbBenchmark
{
	partial class DapperDb
	{

		// available inactive command for ReadSingleRow (interlocked)
		private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_DapperDb_input_cs_ReadSingleRow_94;

		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		[global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
		private async partial global::System.Threading.Tasks.Task<global::Dapper.Samples.DapperDbBenchmark.World> ReadSingleRow(int id, global::System.Data.Common.DbConnection? db)
		{
			// locals
			global::System.Data.Common.DbCommand? __dapper__command = null;
			global::System.Data.Common.DbDataReader? __dapper__reader = null;
			bool __dapper__close = false;
			int[]? __dapper__tokenBuffer = null;
			try
			{
				// prepare connection
				if (db!.State == global::System.Data.ConnectionState.Closed)
				{
					await db!.OpenAsync(global::System.Threading.CancellationToken.None).ConfigureAwait(false);
					__dapper__close = true;
				}

				// prepare command (excluding parameter values)
				if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_DapperDb_input_cs_ReadSingleRow_94, null)) is null)
				{
					__dapper__command = __dapper__CreateCommand(db!);
				}
				else
				{
					__dapper__command.Connection = db;
				}

				// assign parameter values
#pragma warning disable CS0618
				__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
#pragma warning restore CS0618

				// execute reader
				const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
				__dapper__reader = await __dapper__command.ExecuteReaderAsync(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior, global::System.Threading.CancellationToken.None).ConfigureAwait(false);
				__dapper__close = false; // performed via CommandBehavior

				// process single row
				global::Dapper.Samples.DapperDbBenchmark.World __dapper__result;
				if (__dapper__reader.HasRows && await __dapper__reader.ReadAsync(global::System.Threading.CancellationToken.None).ConfigureAwait(false))
				{
					__dapper__result = await global::Dapper.TypeReader.TryGetReader<global::Dapper.Samples.DapperDbBenchmark.World>()!.ReadAsync(__dapper__reader, ref __dapper__tokenBuffer, global::System.Threading.CancellationToken.None).ConfigureAwait(false);
				}
				else
				{
					__dapper__result = default!;
				}
				// consume additional results (ensures errors from the server are observed)
				while (await __dapper__reader.NextResultAsync(global::System.Threading.CancellationToken.None).ConfigureAwait(false)) { }
				return __dapper__result;

				// TODO: post-process parameters

			}
			finally
			{
				// cleanup
				global::Dapper.TypeReader.Return(ref __dapper__tokenBuffer);
				if (__dapper__reader is not null) await __dapper__reader.DisposeAsync().ConfigureAwait(false);
				if (__dapper__command is not null)
				{
					__dapper__command.Connection = default;
					__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_DapperDb_input_cs_ReadSingleRow_94, __dapper__command);
					if (__dapper__command is not null) await __dapper__command.DisposeAsync().ConfigureAwait(false);
				}
				if (__dapper__close) await (db?.CloseAsync() ?? global::System.Threading.Tasks.Task.CompletedTask).ConfigureAwait(false);
			}

			// command factory for ReadSingleRow
			[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
			[global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
			static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
			{
				var command = connection.CreateCommand();
				if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
				{
					typed0.BindByName = true;
					typed0.InitialLONGFetchSize = -1;
				}
				command.CommandType = global::System.Data.CommandType.Text;
				command.CommandText = @"/* DapperDb.ReadSingleRow, Samples/DapperDb.input.cs #94 */ SELECT id, randomnumber FROM world WHERE id = @id";
				var args = command.Parameters;

				var p = command.CreateParameter();
				p.ParameterName = @"id";
				p.Direction = global::System.Data.ParameterDirection.Input;
				args.Add(p);

				return command;
			}
		}



		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		[global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
		private async partial global::System.Threading.Tasks.Task ExecuteBatch(string command, global::System.Collections.Generic.Dictionary<string, int> parameters, global::System.Data.Common.DbConnection? db)
		{
			// locals
			global::System.Data.Common.DbCommand? __dapper__command = null;
			bool __dapper__close = false;
			try
			{
				// prepare connection
				if (db!.State == global::System.Data.ConnectionState.Closed)
				{
					await db!.OpenAsync(global::System.Threading.CancellationToken.None).ConfigureAwait(false);
					__dapper__close = true;
				}

				// prepare command (excluding parameter values)
				__dapper__command = __dapper__CreateCommand(db!, command);

				// assign parameter values
#pragma warning disable CS0618
				__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(parameters);
#pragma warning restore CS0618

				// execute non-query
				await __dapper__command.ExecuteNonQueryAsync(global::System.Threading.CancellationToken.None).ConfigureAwait(false);

				// TODO: post-process parameters

			}
			finally
			{
				// cleanup
				if (__dapper__command is not null)
				{
					await __dapper__command.DisposeAsync().ConfigureAwait(false);
				}
				if (__dapper__close) await (db?.CloseAsync() ?? global::System.Threading.Tasks.Task.CompletedTask).ConfigureAwait(false);
			}

			// command factory for ExecuteBatch
			[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
			[global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
			static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection, string? commandText)
			{
				var command = connection.CreateCommand();
				if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
				{
					typed0.BindByName = true;
					typed0.InitialLONGFetchSize = -1;
				}
				command.CommandType = global::System.Data.CommandType.Text;
				command.CommandText = commandText;
				var args = command.Parameters;

				var p = command.CreateParameter();
				p.ParameterName = @"parameters";
				p.Direction = global::System.Data.ParameterDirection.Input;
				args.Add(p);

				return command;
			}
		}
	}
}

namespace Dapper.Internal.__dapper__Run_TypeReaders
{
	file sealed class __dapper__CommandGenerator_TypeReader : global::Dapper.TypeReader<global::Dapper.Samples.DapperDbBenchmark.World>
	{
		private __dapper__CommandGenerator_TypeReader() { }
		internal static readonly __dapper__CommandGenerator_TypeReader Instance = new();

		protected override int GetColumnToken(string name, global::System.Type? type, bool isNullable)
		{
			switch (name)
			{
				case @"<Id>k__BackingField":
					return 0;
				case @"Id":
					return 1;
				case @"<_Id>k__BackingField":
					return 2;
				case @"_Id":
					return 3;
				case @"<RandomNumber>k__BackingField":
					return 4;
				case @"RandomNumber":
					return 5;
			}
			return NoField;
		}

		protected override global::Dapper.Samples.DapperDbBenchmark.World ReadFallback(global::System.Data.IDataReader reader, global::System.ReadOnlySpan<int> tokens, int offset)
		{
			global::Dapper.Samples.DapperDbBenchmark.World obj = new();
			return obj;
		}
	}
}
#endregion
