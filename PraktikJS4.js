let nama = [
    "Alexa", "Alyn", "Matthew",
    "Oliver", "Noah", "Olivia",
    "James", "Edward", "Lily",
    "Hatake"
];

let nilai = [85, 78, 92, 88, 75, 90, 82, 76, 95, 99];

console.log("DAFTAR NILAI SISWA");
console.log("===================");

for (let i = 0; i < nama.length; i++) {
    console.log(nama[i] + " : " + nilai[i]);
}

console.log("===================");
console.log("Jumlah siswa: " + nama.length);