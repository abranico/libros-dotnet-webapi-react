import { useEffect, useState } from "react";
import Books from "./components/books/Books";

const App = () => {
  const [books, setBooks] = useState([]);

  useEffect(() => {
    fetch("http://localhost:5037/api/Libro")
      .then((response) => response.json())
      .then((data) => setBooks(data));
  }, []);

  console.log(books);

  return (
    <div>
      <h2 className="text-center">¡Bienvenidos a Books Champion!</h2>
      <p className="text-center">¡Quiero leer libros!</p>
      <Books books={books} />
    </div>
  );
};

export default App;
