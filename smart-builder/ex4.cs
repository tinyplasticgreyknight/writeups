using System.Linq;
using System.Collections.Generic;

public static class WidgetBuilder {
	public static State<Empty, Empty, Empty> New() {
		return new State<Empty, Empty, Empty>(new Empty(), new Empty(), new Empty());
	}

	public static State<string, T2, T3> WithName<T2, T3>(this State<Empty, T2, T3> state, string name) {
		return new State<string, T2, T3>(name, state.NumGrommits, state.GrommitSpecies);
	}

	public static State<T1, int, Empty> WithGrommits<T1>(this State<T1, Empty, Empty> state, int num_grommits) {
		return new State<T1, int, Empty>(state.Name, num_grommits, state.GrommitSpecies);
	}

	public static State<T1, int, GrommitSpecies> WithGrommitSpecies<T1>(this State<T1, int, Empty> state, GrommitSpecies grommit_species) {
		return new State<T1, int, GrommitSpecies>(state.Name, state.NumGrommits, grommit_species);
	}

	public static Widget Build(this State<string, int, GrommitSpecies> state) {
		var grommits = Enumerable.Range(0, state.NumGrommits).Select(i => new Grommit(state.GrommitSpecies)).ToList();
		return new Widget(state.Name, grommits);
	}

	public static Widget Build(this State<string, Empty, Empty> state) {
		return new Widget(state.Name, new List<Grommit>());
	}

	public struct State<TName, TNumGrommits, TGrommitSpecies> {
		public TName Name { get; }
		public TNumGrommits NumGrommits { get; }
		public TGrommitSpecies GrommitSpecies { get; }

		public State(TName name, TNumGrommits num_grommits, TGrommitSpecies grommit_species) {
			Name = name;
			NumGrommits = num_grommits;
			GrommitSpecies = grommit_species;
		}
    }
}

