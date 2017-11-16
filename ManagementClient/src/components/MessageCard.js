import React from 'react';
import PropTypes from 'prop-types';

export class MessageCard extends React.Component {
  render() {
    let Message = this.props.Message;
    return (
      <li>
        {Message.Title} - Created: {Message.CreatedDate} by {Message.CreatedBy}
      </li>
    );
  }
}

MessageCard.propTypes = {
  Message: PropTypes.objectOf(PropTypes.string).isRequired
};

export default MessageCard;
