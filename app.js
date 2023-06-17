// Import required modules
const express = require('express');
const app = express();

// Set up the view engine
app.set('view engine', 'ejs');
app.set('views', __dirname + '/views');

// Define routes
app.get('/', (req, res) => {
  res.render('index', { title: 'Home' });
});

app.get('/services', (req, res) => {
  res.render('services', { title: 'Services' });
});

app.get('/about', (req, res) => {
  res.render('about', { title: 'About Us' });
});

// Start the server
app.listen(3000, () => {
  console.log('Server is running on port 3000');
});