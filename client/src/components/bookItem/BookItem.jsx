import PropTypes from "prop-types";
import { Card } from "react-bootstrap";
const BookItem = ({ title, author, genre, date, imageUrl }) => {
  return (
    <Card className="m-3 bg-dark text-light" style={{ width: "22rem" }}>
      <Card.Img src={imageUrl ?? "https://picsum.photos/200"} />
      <Card.Body>
        <Card.Title>{title}</Card.Title>
        <Card.Subtitle>{author}</Card.Subtitle>
        <div>{genre}</div>
        <p className="fw-bold">{date}</p>
      </Card.Body>
    </Card>
  );
};

export default BookItem;

BookItem.propTypes = {
  title: PropTypes.string,
  author: PropTypes.string,
  pages: PropTypes.number,
  rating: PropTypes.array,
};
