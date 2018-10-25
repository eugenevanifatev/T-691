class StringGenerator {
	
	constructor(stringLength, firstSymbol, lastSymbol) {
		this.firstSymbolCode = firstSymbol;
		this.lastSymbolCode = lastSymbol;
		
		if (!isNaN(parseInt(stringLength))) {
			this.stringLength = parseInt(stringLength);
			this.generate();
		} else {
			this.generatedString = false;
		}
	}

	randomInteger(min, max) {
		let randInt = min + Math.random() * (max + 1 - min);
		randInt = Math.floor(randInt);
		return randInt;
	}

	generate() {
		this.generatedString = '';
		for(let i = 0; i < this.stringLength; ++i) {
			this.generatedString += String.fromCharCode( this.randomInteger(this.firstSymbolCode, this.lastSymbolCode) );
		}
	}
}