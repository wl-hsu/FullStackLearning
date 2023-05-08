function checkEmailId (str) {
    let atIndex = str.toLowerCase().indexOf('@')
    let dotIndex = str.toLowerCase().indexOf('.')
    if (atIndex !== -1 && dotIndex !== -1 && atIndex < dotIndex) {
        return true
    } else {
        return false
    }
}

// test case:
console.log(checkEmailId('test@test.com'))
console.log(checkEmailId('test@test'))
console.log(checkEmailId('test.com'))
console.log(checkEmailId('test@.com')) 