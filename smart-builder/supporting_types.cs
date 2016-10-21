using System.Collections.Generic;

public struct Empty {
}

public class Widget {
	public Widget(string name) {
	}

	public Widget(string name, IEnumerable<Grommit> grommits) {
	}
}

public class Grommit {
	public Grommit() {
	}

	public Grommit(GrommitSpecies species) {
	}
}

public enum GrommitSpecies {
	Vanilla,
	MintChocChip,
	Cherry
}

public interface StreamProducer<T> : IEnumerable<T> {
}

