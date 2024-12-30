/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./**/*.{cshtml,razor}",
        "./Pages/**/*.{cshtml,razor}",
        "./Pages/MachinePages/**/*.{cshtml,razor}",
        "./wwwroot/js/**/*.js"],
    theme: {
        extend: {},
    },
    plugins: [],
}
