class Builder {
	
	private int height;
	public string name;

	public Builder(int height){
		this.height = height;
		name = "sam";
	}

	public void repackage() {
		if (this.height >= 10) {
			finalize();
		} else {
			reverify();
		}
	}

	public void finalize() {
		console.log("finalizing...");
	}

	public void reverify() {
        console.log(""); // The change is here 
	}
}