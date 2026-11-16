let totalBelanja = 200000;
let diskon = 0;
let potonganHarga = 0;
let totalBayar = totalBelanja;
let keterangan;

if (totalBelanja >= 100000) {
    diskon = 30;
    potonganHarga = totalBelanja * diskon / 100;
    totalBayar = totalBelanja - potonganHarga;
    keterangan = "Mendapatkan diskon 30%";
} else {
    keterangan = "Tidak mendapatkan diskon";
}

console.log("Pengecekan Hasil Diskon");
console.log("------------------------");

console.log("Total belanja: Rp" + totalBelanja);
console.log("Keterangan: " + keterangan);
console.log("Potongan harga: Rp" + potonganHarga);
console.log("------------------------");

console.log("Total setelah diskon: Rp" + totalBayar);