let styles = ['James', 'Brennie']
console.log(styles)

styles.push('Robert')
console.log(styles)

const midIndex = Math.floor(styles.length / 2)
styles[midIndex] = 'Calvin'
console.log(styles)

const first = styles.shift()
console.log(first)
console.log(styles)

styles.unshift('Rose', 'Regal')
console.log(styles)


