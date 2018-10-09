function PasswordGeneration(){
	var Numbers = document.querySelector('input[name="Numbers"]');
	var High_register = document.querySelector('input[name="High-register"]');
	var Low_ = document.querySelector('input[name="Low_"]');
	var Submit = document.getElementsByTagName('Submit');
	var Count = document.getElementsByClassName('radio_length');
	var OutPut = document.getElementById('Output');
	var password = "Your password is: ";
	var n;
	for(let i = 0;i<Count.length;++i){
		if(Count[i].checked == true){
			var passwordLength = Count[i].value;
		}
	}
	switch(passwordLength){
		case '1': n = Math.floor(Math.random() * (8-4) + 4);break;
		case '2': n = Math.floor(Math.random() * (12-9) + 9);break;
		case '3': n = Math.floor(Math.random() * (15-13) + 13);break;
		default: alert('ERROR!');break;
	}
	if(Numbers.checked && High_register.checked && Low_.checked)
		for(let i = 0;i<n;++i){
			var Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_";
			password += Letters.charAt(Math.floor(Math.random() * Letters.length));
		}
	else if(Numbers.checked == false && High_register.checked && Low_.checked)
			for(let i = 0;i<n;++i){
			var Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz_";
			password += Letters.charAt(Math.floor(Math.random() * Letters.length));
		}
	else if(Numbers.checked == false && High_register.checked==false && Low_.checked)
		for(let i = 0;i<n;++i){
		var Letters = "abcdefghijklmnopqrstuvwxyz_";
		password += Letters.charAt(Math.floor(Math.random() * Letters.length));
		}
	else if(Numbers.checked == false && High_register.checked==false && Low_.checked == false)
		for(let i = 0;i<n;++i){
		var Letters = "abcdefghijklmnopqrstuvwxyz";
		password += Letters.charAt(Math.floor(Math.random() * Letters.length));
		}
	else if(Numbers.checked && High_register.checked==false && Low_.checked == false)
		for(let i = 0;i<n;++i){
		var Letters = "abcdefghijklmnopqrstuvwxyz0123456789";
		password += Letters.charAt(Math.floor(Math.random() * Letters.length));
		}
	else if(Numbers.checked==false && High_register.checked && Low_.checked == false)
		for(let i = 0;i<n;++i){
		var Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
		password += Letters.charAt(Math.floor(Math.random() * Letters.length));
		}
	else if(Numbers.checked && High_register.checked==false && Low_.checked)
		for(let i = 0;i<n;++i){
			var Letters = "abcdefghijklmnopqrstuvwxyz0123456789_";
		password += Letters.charAt(Math.floor(Math.random() * Letters.length));
		}	
	OutPut.innerHTML = password;
}