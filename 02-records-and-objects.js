 // Object JavaScript (struct C#) etc

const recordBook = [{
    name: 'Harry Potter and the Philosopher Stone',
    numberPages: '256',
    price: 82.76
}];

recordBook.map((book) => {
    console.log(`Name: ${book.name}, Pages: ${book.numberPages}, Price: ${ book.price}`)
})
