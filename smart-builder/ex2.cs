using System.Linq;

public static class WidgetBuilder {
	public static State<Empty, Empty> New() {
		return new State<Empty, Empty>(new Empty(), new Empty());
	}

	public static State<string, T> WithName<T>(this State<Empty, T> state, string name) {
		return new State<string, T>(name, state.NumGrommits);
	}

	public static State<T, int> WithGrommits<T>(this State<T, Empty> state, int num_grommits) {
		return new State<T, int>(state.Name, num_grommits);
	}

	public static Widget Build(this State<string, int> state) {
		var grommits = Enumerable.Range(0, state.NumGrommits).Select(i => new Grommit()).ToList();
		return new Widget(state.Name, grommits);
	}

	public struct State<TName, TNumGrommits> {
		public TName Name { get; }
		public TNumGrommits NumGrommits { get; }

		public State(TName name, TNumGrommits num_grommits) {
			Name = name;
			NumGrommits = num_grommits;
		}
    }
}

