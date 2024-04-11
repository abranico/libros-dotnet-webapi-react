import BookItem from "../bookItem/BookItem";

const Books = ({ books }) => {
  return (
    <div className="d-flex justify-content-center flex-wrap">
      {books.map((book) => (
        <BookItem
          key={book.id}
          title={book.titulo}
          author={book.autor}
          genre={book.genero}
          date={book.fechaPublicacion}
          imageUrl={book.imageUrl}
        />
      ))}
    </div>
  );
};

export default Books;
