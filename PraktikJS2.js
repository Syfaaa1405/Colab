let barang1 = "1 Pack Buku";
let harga1 = 39000;
let jumlah1 = 2;

let barang2 = "Pensil";
let harga2 = 4000;
let jumlah2 = 2;

let barang3 = "Penghapus";
let harga3 = 3500;
let jumlah3 = 1;

let barang4 = "Penggaris";
let harga4 = 5000;
let jumlah4 = 1;

let subtotal1 = harga1 * jumlah1;
let subtotal2 = harga2 * jumlah2;
let subtotal3 = harga3 * jumlah3;
let subtotal4 = harga4 * jumlah4;

let total = subtotal1 + subtotal2 + subtotal3 + subtotal4;

console.log("Menghitung Hasil Belanja");
console.log("------------------------");

console.log(barang1 + " (" + jumlah1 + ") : Rp" + subtotal1);
console.log(barang2 + " (" + jumlah2 + ") : Rp" + subtotal2);
console.log(barang3 + " (" + jumlah3 + ") : Rp" + subtotal3);
console.log(barang4 + " (" + jumlah4 + ") : Rp" + subtotal4);

console.log("------------------------");
console.log("Total Belanja: Rp" + total);