let generateBtn = document.getElementById('generate');

generateBtn.addEventListener('click', function() {
	let codeLength = document.getElementById('input-length').value;
	let hashCode = new StringGenerator(codeLength, 48, 122);

	document.getElementById('out-code').innerHTML = hashCode.generatedString
});