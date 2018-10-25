function getEnglishAlphabet() {
    let str = '';
    for(let i = 97; i <= 122; ++i) {
        str += String.fromCharCode(i);
    }
    return str;
}

function shift(str, n) {
    return str.slice(-n) + str.slice(0, -n);
}

function createVigenereTable(getAlphabet) {
    let table = [];
    let str = getAlphabet();
    for (let i = 0; i < 26; ++i) {
        table.push(str);
        str = shift(str, -1);
    }
    return table;
}

function completeKey(key, wordLength) {
    let temp = key;
    let keyLength = key.length;
    let tempLength = temp.length;

    for (; tempLength < wordLength;) {
        for (let i = 0; i < keyLength; ++i) {
            if (tempLength === wordLength) {
                break;
            }
            temp += key[i];
            tempLength++;
        }
    }
    return temp;
}

function findWordIndex(str, char) {
    for (let i = 0; i < str.length; ++i) {
        if (str[i] === char) {
            return i;
        }
    }
    return -1;
}

function encryption(table, word, key) {
    key = completeKey(key, word.length);
    let result = '';
    let wordLength = word.length;
    let wordIndex = 0;
    let keyIndex = 0;

    for (let i = 0; i < wordLength; ++i) {
        wordIndex = findWordIndex(table[0], word[i]);
        keyIndex = findWordIndex(table[0], key[i]);
        result += table[keyIndex][wordIndex];
    }
    return result;
}

function decode(table, code, key) {
    let result = '';
    let codeLenght = code.length;
    let codeIndex = 0;
    let keyIndex = 0;
    key = completeKey(key, codeLenght);

    for (let i = 0; i < codeLenght; ++i) {
        keyIndex = findWordIndex(table[0], key[i]);
        codeIndex = findWordIndex(table[keyIndex], code[i]);
        result += table[0][codeIndex];
    }
    return result;
}
function isValidEnglshWord(word) {
    let pattern = /[a-z]+/;
    return pattern.exec(word) !== null;
}
document.getElementById('encrypt').addEventListener('click', () => {
    let word = document.getElementById('word').value.toLowerCase();
    let keyword = document.getElementById('keyword').value.toLowerCase();
    if (isValidEnglshWord(word) && isValidEnglshWord(keyword)) {
        let table = createVigenereTable(getEnglishAlphabet);
        let outputCode = document.getElementById('out-code');
        outputCode.innerHTML += encryption(table, word, keyword);
    } else {
        console.error('You should input only english letters (without spaces)');
    }
});

document.getElementById('decode').addEventListener('click', () => {
    let code = document.getElementById('code').value.toLowerCase();
    let keyword = document.getElementById('keyword-code').value.toLowerCase();
    if (isValidEnglshWord(code) && isValidEnglshWord(keyword)) {
        let outputDecode = document.getElementById('out-decode');
        let table = createVigenereTable(getEnglishAlphabet);
        outputDecode.innerHTML += decode(table, code, keyword);
    } else {
        console.error('You should input only english letters (without spaces)');
    }

});