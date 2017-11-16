import React from 'react';
import PropTypes from 'prop-types';

export class MessageEdit extends React.Component {
  render() {
    let Message = this.props.Message || {Links: [{}], Groups: [{}]};
    return (
      <form>
        <div><label>Title:</label> <input type="text" value={Message.Title || ""} /></div>
        <div><label>Body:</label> <textarea value={Message.Body || ""} /></div>
        <div><label>Link Text:</label> <input type="text" value={Message.Links[0].Name || ""} /></div>
        <div><label>Link URI:</label> <input type="text" value={Message.Links[0].Uri || ""} /></div>
        <div><label>Start Date:</label> <input type="text" value={Message.StartDate || ""} /></div>
        <div><label>End Date:</label> <input type="text" value={Message.EndDate || ""} /></div>
      </form>
    );
  }
}

MessageEdit.propTypes = {
  Message: PropTypes.objectOf(PropTypes.string)
};

export default MessageEdit;
