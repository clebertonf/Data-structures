// array
const arrayNames = ['Cleberton', 'Katrine', 'Marta', 'Edilson'];
const arrayNumbers = [1, 2, 3, 4 ,5];

arrayNames.map((name) => console.log(name));
arrayNumbers.map((number) => console.log(number));

// matriz

const matrizNumbers = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

for(let line = 0; line < matrizNumbers.length; line ++){
    for(let column = 0; column < matrizNumbers.length; column ++){
        console.log(matrizNumbers[line] [column])
    }
}
