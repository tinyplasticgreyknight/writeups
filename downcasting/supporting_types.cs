// supporting and mock types of unimportant functionality
using System;
using System.Collections.Generic;

public class AssertionFailedException : Exception {
	public AssertionFailedException(string message) : base(message) {
	}
}

public static class Assert {
	public static void AreEqual(uint expected, uint actual) {
		if (expected == actual) {
			return;
		}

		throw new AssertionFailedException(string.Format("assertion failed\nexpected: {0}\nactual: {1}", expected, actual));
	}

	public static void IsNotNull<T>(T value) {
		if (value == null) {
			throw new AssertionFailedException("expected non-null reference");
		}
	}

	public static void OfType<T>(object value) where T : class {
		if ((value as T) == null) {
			throw new AssertionFailedException(string.Format("wrong type\nexpected: {0}\nactual: {1}", typeof(T).FullName, value.GetType().FullName));
		}
	}
}

public static class DatabasePool {
	public static IDictionary<Guid, uint> entries = new Dictionary<Guid, uint>();

	public static DatabaseConnection Get() {
		return new DatabaseConnection(entries);
	}
}

public class DatabaseConnection {
	private readonly IDictionary<Guid, uint> table;

	public DatabaseConnection(IDictionary<Guid, uint> table) {
		this.table = table;
	}

	public Guid CreateGrommit(uint initialLen) {
		var ident = Guid.NewGuid();
		table.Add(ident, initialLen);
		return ident;
	}

	public uint QueryGrommitLength(Guid ident) {
		return table[ident];
	}

	public void ModifyGrommitLength(Guid ident, uint length) {
		table[ident] = length;
	}
}

public class Plumbus : IPlumbus {
	public uint Radius { get; set; }

	public Plumbus(uint radius) {
		Radius = radius;
	}
}
