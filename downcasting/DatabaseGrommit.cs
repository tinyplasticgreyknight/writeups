public class DatabaseGrommit : IGrommit {
	private DatabaseConnection dbconn;
	private System.Guid ident;

	public DatabaseGrommit(uint initialLen, DatabaseConnection dbconn) {
		this.dbconn = dbconn;
		this.ident = dbconn.CreateGrommit(initialLen);
	}

	public uint GetLength() {
		return dbconn.QueryGrommitLength(ident);
	}

	public void SetLength(uint length) {
		dbconn.ModifyGrommitLength(ident, length);
	}
}
