public class Widget1 : IWidget {
	public IGrommit AttachedGrommit { get; }

	public Widget1() {
		AttachedGrommit = new DatabaseGrommit(0, DatabasePool.Get());
	}

	public uint GetSize() {
		return AttachedGrommit.GetLength();
	}
}
