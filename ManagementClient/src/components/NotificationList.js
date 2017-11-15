import React from 'react';
import PropTypes from 'prop-types';
import MessageCard from './MessageCard';

export class NotficationList extends React.Component {
  render() {
    return (
      <ul>
        {this.props.Notifications.map((n) => <MessageCard key={n.Id} Message={n} />)}
      </ul>
    );
  }
}

NotficationList.propTypes = {
  View: PropTypes.string.isRequired,
  Notifications: PropTypes.objectOf(PropTypes.string)
};

export default NotficationList;
