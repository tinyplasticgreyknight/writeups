public static class WidgetBuilder {
	public static State<Empty> New() {
		return new State<Empty>(new Empty());
	}

	public static State<string> WithName(this State<Empty> state, string name) {
		return new State<string>(name);
	}

	public static Widget Build(this State<string> state) {
		return new Widget(state.Name);
	}

	public struct State<TName> {
		public TName Name { get; }

		public State(TName name) {
			Name = name;
		}
    }
}

